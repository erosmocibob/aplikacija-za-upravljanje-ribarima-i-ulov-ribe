using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Web.UI.DataVisualization.Charting;



namespace Aplikacija
{
    public partial class WindowPovijestUlovaRadnika : MetroFramework.Forms.MetroForm
    {
        public List<Ulov> ulovPrikaz;
        public List<Ulov> llistaulova;
        public List<UlovStavka> ulovstavkaSVIKbrod;
        public List<UlovStavka> stavkeulova { get; private set; }

        public WindowPovijestUlovaRadnika()
        {
            InitializeComponent();
        }

        private List<UlovStavka> dohvatiStavkeUlova(long? idUlova, List<UlovStavka> sveStavkeSvihUlova)
        {
            List<UlovStavka> stavkeUlova = new List<UlovStavka> { };

            foreach (var stavka in sveStavkeSvihUlova)
            {
                if (stavka.Id_ulova == idUlova)
                {
                    stavkeUlova.Add(stavka);
                }
            }
            return stavkeUlova;
        }

        private void WindowPovijestUlovaRadnika_Load(object sender, EventArgs e)
        {
            var deleteButton = new DataGridViewButtonColumn();

            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Obriši";
            deleteButton.Text = "Delete";
            deleteButton.Width = 70;
            deleteButton.UseColumnTextForButtonValue = true;
            this.dgUlov.Columns.Add(deleteButton);

            metroTabControl1.SelectedTab = metroTabPage1;

            chartRibe.Series["Kilaža"]["PieLabelStyle"] = "Outside";
            chartRibe.Series["Kilaža"].BorderWidth = 1;
            chartRibe.Series["Kilaža"].BorderColor = System.Drawing.Color.FromArgb(26, 59, 105);

            chart1.Series["Kilaža"]["PieLabelStyle"] = "Outside";
            chart1.Series["Kilaža"].BorderWidth = 1;
            chart1.Series["Kilaža"].BorderColor = System.Drawing.Color.FromArgb(26, 59, 105);

            long idKBroda = WindowPrijavaRibara.IdKBroda;
            ulovPrikaz = DBUlov.DohvatiUlovKapID(idKBroda);

            List<UlovStavka> ulovStavka = new List<UlovStavka>();
            ulovStavka = DBStavkaUlov.DohvatiSveUlovStavkeIRibe();

            foreach(var b in ulovPrikaz)
            {
                b.UlovList = this.dohvatiStavkeUlova(b.id, ulovStavka);             
            }         

            var ulovPresenter = new ObservableCollection<Ulov>(ulovPrikaz);
            dgUlov.DataSource = ulovPresenter;

        }

        private void dgUlov_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var ulov = this.ulovPrikaz[e.RowIndex];
            var stavkePresenter = new ObservableCollection<StavkaPresenter>(StavkaPresenter.ToPresenter(ulov.UlovList));
            dgStavkaUlov.DataSource = stavkePresenter;

            foreach (var series in chartRibe.Series)
            {
                series.Points.Clear();
            }
            int i = 0;
            foreach(var stavka in ulov.UlovList)
            {
                chartRibe.Series["Kilaža"].Points.AddXY(stavka.Riba.Naziv,stavka.Kolicina);
                chartRibe.Series["Kilaža"].Points[i].Label = stavka.Kolicina.ToString() + " kg";
                i++;
            }

            chartRibe.Series["Kilaža"].IsValueShownAsLabel = true;
            chartRibe.Series["Kilaža"].LegendText = "#VALX (#PERCENT)";

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            long idKBroda = WindowPrijavaRibara.IdKBroda;


            ulovstavkaSVIKbrod = DBStavkaUlov.DohvatiOdDoKBrod(DateTimePocDatum.Value, DateTimeKrajDatum.Value, idKBroda);
            var sortiranUlovList = ulovstavkaSVIKbrod.OrderByDescending(stavka => stavka.Kolicina).ToList();

           for(int i=0; i< sortiranUlovList.Count; i++)
            {
                var stavka = sortiranUlovList[i];

                chart1.Series["Kilaža"].Points.AddXY(stavka.Riba.Naziv, stavka.Kolicina);
                chart1.Series["Kilaža"].Points[i].Label = stavka.Kolicina.ToString() + " kg";
            }

            chart1.Series["Kilaža"].IsValueShownAsLabel = true;
            chart1.Series["Kilaža"].LegendText = "#VALX (#PERCENT)";
            chart1.Titles["Title1"].Text = "Ulov ribe od " + DateTimePocDatum.Value.ToShortDateString() + " do " + DateTimeKrajDatum.Value.ToShortDateString();

            ulovPrikaz = DBUlov.DohvatiOdDo(DateTimePocDatum.Value, DateTimeKrajDatum.Value, idKBroda);

            var ulovPresenter = new ObservableCollection<Ulov>(ulovPrikaz);
            dgUlov.DataSource = ulovPresenter;

            List<UlovStavka> ulovStavka = new List<UlovStavka>();
            ulovStavka = DBStavkaUlov.DohvatiSveUlovStavkeIRibe();

            foreach (var b in ulovPrikaz)
            {
                b.UlovList = this.dohvatiStavkeUlova(b.id, ulovStavka);
            }
        }
        private void dgUlov_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == dgUlov.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgUlov.Columns["dataGridViewDeleteButton"].Index)
            {
                var result = MetroFramework.MetroMessageBox.Show(this, "Jeste li sigurni da želite Izbrisati ulov i sve stavke tog ulova", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (result == DialogResult.Yes)
                {
                    this.ulovPrikaz.RemoveAt(e.RowIndex);
                    int id_ulov = Convert.ToInt32(dgUlov.Rows[e.RowIndex].Cells[0].Value);
                    DBUlov.IzbrisiUloviStavke(id_ulov);

                    long idKBroda = WindowPrijavaRibara.IdKBroda;

                    dgUlov.DataSource = null;
                    ulovPrikaz = DBUlov.DohvatiUlovKapID(idKBroda);

                    var ulovPresenter = new ObservableCollection<Ulov>(ulovPrikaz);
                    dgUlov.DataSource = ulovPresenter;

                    MetroFramework.MetroMessageBox.Show(this, "Uspješno ste izrisali ulov i stavke ulova", "Informacija", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    List<UlovStavka> ulovStavka = new List<UlovStavka>();
                    ulovStavka = DBStavkaUlov.DohvatiSveUlovStavkeIRibe();

                    foreach (var b in ulovPrikaz)
                    {
                        b.UlovList = this.dohvatiStavkeUlova(b.id, ulovStavka);
                    }
                }
            }
        }
    }
}
