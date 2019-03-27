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

namespace Aplikacija
{
    public partial class WindowUnosUlova : MetroFramework.Forms.MetroForm
    {
        public long idKBroda = WindowPrijavaRibara.IdKBroda;
        public List<UlovStavka> ulovPrikaz;
        public List<UlovStavka> ulovList;
        public Ulov ulov;     

        public WindowUnosUlova()
        {
            InitializeComponent();
            this.ulovList = new List<UlovStavka> { };
        }
   
        private void WindowUnosUlova_Load(object sender, EventArgs e)
        {          
            PocetakUlova.Value = PocetakUlova.Value.AddHours(-1.00);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Obriši";
            deleteButton.Text = "Delete";
            deleteButton.Width = 70;
            deleteButton.UseColumnTextForButtonValue = true;
            this.dgRibe.Columns.Add(deleteButton);
 
            List<Riba> listariba = DBRiba.DohvatiSveRibe();

            foreach (var a in listariba)
            {                
                ComboboxItem item = new ComboboxItem();
                item.Text = a.Naziv;
                item.Value = a.id;

                ComboBoxRibe.Items.Add(item);
            }

            List<Brod> listaBrod = DBBrod.DohvatiBrodSRadnicima(idKBroda);
            foreach (var brod in listaBrod)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = brod.Ime;
                item.Value = brod.id;
                comboBoxBrod.Items.Add(item);
            }
           
            if (!listaBrod.Any())
            {
                MetroFramework.MetroMessageBox.Show(this, "Nemate niti jedan brod s radnicima molim dodajete radnike na brodu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            comboBoxBrod.Text = "--odaberi brod--"; 

            ComboBoxRibe.Text = "--traži ribu--";
            Datumulova.MinDate = new DateTime(2018, 12, 1);
            Datumulova.MaxDate = DateTime.Today;
            Datumulova.Format = DateTimePickerFormat.Custom;
            Datumulova.CustomFormat = "dd. MMMM. yyyy - dddd";
        }

        private void Datumulova_ValueChanged(object sender, EventArgs e)
        {
            if (Datumulova.Value.Date == DateTime.Now.Date)
            {
                buttonPlusDan.Enabled = false;
                buttonPlusDan.BackColor = Color.Red;
            }
            else
            {
                buttonPlusDan.Enabled = true;
                buttonPlusDan.BackColor = Color.LimeGreen;
            }
        }

        private void Natrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void ComboBoxRibe_MouseClick(object sender, MouseEventArgs e)
        {
            ComboBoxRibe.Text = "";
        }

        private void ButtonDodajribu_Click(object sender, EventArgs e)
        {
            if(ComboBoxRibe.SelectedItem == null || decimal.ToDouble(numericUpDownKilaza.Value) == 0.00)
            {
                MetroFramework.MetroMessageBox.Show(this, "Niste odabrali ribu ili niste dodali količinu ribe", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long id_ribe = Convert.ToInt64((ComboBoxRibe.SelectedItem as ComboboxItem).Value.ToString());
                bool vec_postoji= false;
              
                Riba riba = new Riba(ComboBoxRibe.Text.ToString(), id_ribe);
                double doublevalue = decimal.ToDouble(Math.Round(numericUpDownKilaza.Value, 2));

                foreach (var a in ulovList)
                {                    
                    if (id_ribe == a.Riba.Id_ribe)
                    {
                        a.Kolicina += doublevalue;
                        vec_postoji = true;
                    }

                }

                if (vec_postoji == false)
                {
                    this.ulovList.Add(new UlovStavka(doublevalue, riba));
                }
                else
                {
                }               
                var stavkePresenter = new ObservableCollection<StavkaPresenter>(StavkaPresenter.ToPresenter(ulovList));
                dgRibe.DataSource = stavkePresenter;               
            }      

        }

        private void ButtonSpremiUlov_Click(object sender, EventArgs e)
        {
            if(comboBoxBrod.Text=="--odaberi brod--")
            {
                MetroFramework.MetroMessageBox.Show(this, "Niste odabraili brod za ulov", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = MetroFramework.MetroMessageBox.Show(this, "Jeste li sigurni da želite dodait novi ulov", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    long id_brod = Convert.ToInt64((comboBoxBrod.SelectedItem as ComboboxItem).Value.ToString());
                    long idKBroda = WindowPrijavaRibara.IdKBroda;

                    Ulov noviulov = new Ulov(Datumulova.Value.Date, PocetakUlova.Value.ToString("HH:mm"), krajUlova.Value.ToString("HH:mm"), id_brod, idKBroda);
                    long id_ulova = DBUlov.DodajUlov(noviulov);

                    foreach (var a in ulovList)
                    {
                        DBStavkaUlov.DodajStavku(a, id_ulova);
                    }
                    MetroFramework.MetroMessageBox.Show(this, "Uspješno ste dodali novi ulov", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }            
        }

        private void dgRibe_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgRibe.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgRibe.Columns["dataGridViewDeleteButton"].Index)
            {
                this.ulovList.RemoveAt(e.RowIndex);

                dgRibe.DataSource = null;
                var stavkePresenter = new ObservableCollection<StavkaPresenter>(StavkaPresenter.ToPresenter(ulovList));
                dgRibe.DataSource = stavkePresenter;
            }
        }

        private void buttonPlusDan_Click(object sender, EventArgs e)
        {            
            Datumulova.Value = Datumulova.Value.AddDays(1);           
        }

        private void buttonDanMinus_Click(object sender, EventArgs e)
        {
            if (Datumulova.Value == Datumulova.MinDate)
            {
                buttonDanMinus.BackColor = Color.Red;
            }
            else
            {
                buttonDanMinus.BackColor = Color.LimeGreen;
                Datumulova.Value = Datumulova.Value.AddDays(-1);
            }
        }
        
    }
}
