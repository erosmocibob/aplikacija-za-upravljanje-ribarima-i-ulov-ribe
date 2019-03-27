using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Drawing.Imaging;

namespace Aplikacija
{
    public partial class WindowPovijestUlova : MetroFramework.Forms.MetroForm
    {
        public List<Ulov> ulovPrikaz;
        public List<Ulov> llistaulova;
        public List<UlovStavka> ulovstavkaSVIKbrod;
        public List<UlovStavka> ulovstavkaSviUkupanStavke;
        public List<UlovStavka> stavkeulova { get; private set; }

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

        public WindowPovijestUlova()
        {
            InitializeComponent();
        }

        private void WindowPovijestUlova_Load(object sender, EventArgs e)
        {          
            metroTabControl1.SelectedTab = metroTabPage1;   
            List<KapetanBroda> listaKapetan = DBKapetanBroda.DohvatiSveKB();
            ComboboxItem prviItem = new ComboboxItem();

            prviItem.Text = "svi ulovi";
            prviItem.Value = -1;
            ComboBoxKapBroda.Items.Add(prviItem);
            ComboBoxKapBroda.SelectedIndex = 0;

            foreach (var a in listaKapetan)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = a.Ime + " oib: " + a.Oib;
                item.Value = a.id;

                ComboBoxKapBroda.Items.Add(item);
            }

            chartRibe.Series["Kilaža"]["PieLabelStyle"] = "Outside";
            chartRibe.Series["Kilaža"].BorderWidth = 1;
            chartRibe.Series["Kilaža"].BorderColor = System.Drawing.Color.FromArgb(26, 59, 105);

            chart1.Series["Kilaža"]["PieLabelStyle"] = "Outside";
            chart1.Series["Kilaža"].BorderWidth = 1;
            chart1.Series["Kilaža"].BorderColor = System.Drawing.Color.FromArgb(26, 59, 105);

            List<Ulov> ulovPrikaza = DBUlov.DohvatiSveUlov();
        }

        private void dgUlov_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var ulov = this.ulovPrikaz[e.RowIndex];

            double ukupnoKg = 0;
            foreach (var stavka in ulov.UlovList)
            {
                ukupnoKg += stavka.Kolicina;
            }
            label4.Text = ukupnoKg.ToString() + " kg";

            var stavkePresenter = new ObservableCollection<StavkaPresenter>(StavkaPresenter.ToPresenter(ulov.UlovList));
            dgStavkeUlov.DataSource = stavkePresenter;

            foreach (var series in chartRibe.Series)
            {
                series.Points.Clear();
            }

            var sortiranUlovList = ulov.UlovList.OrderByDescending(stavka => stavka.Kolicina).ToList();

            for(int i=0; i< sortiranUlovList.Count; i++)
            {
                var stavka = sortiranUlovList[i];
                chartRibe.Series["Kilaža"].Points.AddXY(stavka.Riba.Naziv, stavka.Kolicina);
              chartRibe.Series["Kilaža"].Points[i].Label = stavka.Kolicina.ToString()+" kg";

            }
           
            chartRibe.Series["Kilaža"].IsValueShownAsLabel = true;
            chartRibe.Series["Kilaža"].LegendText = "#VALX (#PERCENT)";
        }

        private void ComboBoxKBroda_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            if (ComboBoxKapBroda.SelectedIndex == 0)
            {
                ulovPrikaz = DBUlov.DohvatiSveUlov();
                var ulovPresenter = new ObservableCollection<Ulov>(ulovPrikaz);
                dgUlov.DataSource = ulovPresenter;

                List<UlovStavka> ulovStavka = new List<UlovStavka>();
                ulovStavka = DBStavkaUlov.DohvatiSveUlovStavkeIRibe();

                foreach (var b in ulovPrikaz)
                {
                    b.UlovList = this.dohvatiStavkeUlova(b.id, ulovStavka);
                }

                List<UlovStavka> ukupanUlovstavke = new List<UlovStavka>();

                ukupanUlovstavke = DBStavkaUlov.DohvatiSveUlovStavkeIRibeUkupno();

                var sortiranUlovList = ukupanUlovstavke.OrderByDescending(stavka => stavka.Kolicina).ToList();

                for (int i = 0; i < sortiranUlovList.Count; i++)
                {
                    var stavka = sortiranUlovList[i];

                    chart1.Series["Kilaža"].Points.AddXY(stavka.Riba.Naziv, stavka.Kolicina);
                    chart1.Series["Kilaža"].Points[i].Label = stavka.Kolicina.ToString() + " kg";


                }

                chart1.Series["Kilaža"].IsValueShownAsLabel = true;
                chart1.Series["Kilaža"].LegendText = "#VALX (#PERCENT)";
                chart1.Titles["Title1"].Text = "Sve ukupan ulov ribe";
            }
            else
            {
                long id_KapBrod = Convert.ToInt64((ComboBoxKapBroda.SelectedItem as ComboboxItem).Value.ToString());
                ulovPrikaz = DBUlov.DohvatiUlovKapID(id_KapBrod);

                var ulovPresenter = new ObservableCollection<Ulov>(ulovPrikaz);
                dgUlov.DataSource = ulovPresenter;

                List<UlovStavka> ulovStavka = new List<UlovStavka>();
                ulovStavka = DBStavkaUlov.DohvatiSveUlovStavkeIRibe();

                foreach (var b in ulovPrikaz)
                {
                    b.UlovList = this.dohvatiStavkeUlova(b.id, ulovStavka);
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            long id_KapBrod = Convert.ToInt64((ComboBoxKapBroda.SelectedItem as ComboboxItem).Value.ToString());

            if (id_KapBrod == -1)
            {
                ulovPrikaz = DBUlov.DohvatiOdDoSvi(DateTimePocDatum.Value, DateTimeKrajDatum.Value);
                ulovstavkaSviUkupanStavke = DBStavkaUlov.DohvatiOdDoSveUlovStave(DateTimePocDatum.Value, DateTimeKrajDatum.Value);

                int i = 0;
                foreach (var a in ulovstavkaSviUkupanStavke)
                {
                    chart1.Series["Kilaža"].Points.AddXY(a.Riba.Naziv, a.Kolicina);
                    chart1.Series["Kilaža"].Points[i].Label = a.Kolicina.ToString() + " kg";
                    i++;
                }
                chart1.Series["Kilaža"].LegendText = "#VALX (#PERCENT)";
                chart1.Series["Kilaža"].IsValueShownAsLabel = true;
                chart1.Titles["Title1"].Text = "Ulov ribe od " + DateTimePocDatum.Value.ToShortDateString() + " do " + DateTimeKrajDatum.Value.ToShortDateString();

            }
            else
            {
                ulovPrikaz = DBUlov.DohvatiOdDo(DateTimePocDatum.Value, DateTimeKrajDatum.Value, id_KapBrod);
                ulovstavkaSVIKbrod = DBStavkaUlov.DohvatiOdDoKBrod(DateTimePocDatum.Value, DateTimeKrajDatum.Value, id_KapBrod);

                var sortiranUlovList = ulovstavkaSVIKbrod.OrderByDescending(stavka => stavka.Kolicina).ToList();

                for (int i = 0; i < sortiranUlovList.Count; i++)
                {
                    var stavka = sortiranUlovList[i];
                    chart1.Series["Kilaža"].Points.AddXY(stavka.Riba.Naziv, stavka.Kolicina);                   
                    chart1.Series["Kilaža"].Points[i].Label = stavka.Kolicina.ToString() + " kg";
                }                

                chart1.Series["Kilaža"].IsValueShownAsLabel = true;
                chart1.Series["Kilaža"].LegendText = "#VALX (#PERCENT)";
                chart1.Titles["Title1"].Text = "Ulov ribe od " + DateTimePocDatum.Value.ToShortDateString() + " do " + DateTimeKrajDatum.Value.ToShortDateString();

            }

            var ulovPresenter = new ObservableCollection<Ulov>(ulovPrikaz);
            dgUlov.DataSource = ulovPresenter;

            List<UlovStavka> ulovStavka = new List<UlovStavka>();
            ulovStavka = DBStavkaUlov.DohvatiSveUlovStavkeIRibe();

            foreach (var b in ulovPrikaz)
            {
                b.UlovList = this.dohvatiStavkeUlova(b.id, ulovStavka);
            }          

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {      
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Spremi graf";
            saveFileDialog.FileName = chart1.Titles["Title1"].Text;
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = (FileStream)saveFileDialog.OpenFile();
                this.chart1.SaveImage(fs, ImageFormat.Jpeg);
                string path = Path.GetFullPath(saveFileDialog.FileName);
                MetroFramework.MetroMessageBox.Show(this, "Uspješno ste spremili graf na lokaciji:" + path, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
