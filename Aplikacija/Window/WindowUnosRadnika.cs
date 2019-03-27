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
    public partial class WindowUnosRadnika : MetroFramework.Forms.MetroForm
    {
        public long idKBroda = WindowPrijavaRibara.IdKBroda;
        public List<Radnik> radnikPrikaz;

        public WindowUnosRadnika()
        {
            InitializeComponent();
        }

        private void WindowUnosRadnika_Load(object sender, EventArgs e)
        {         
            var deleteButton = new DataGridViewButtonColumn();

            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Obriši";
            deleteButton.Text = "Delete";
            deleteButton.Width = 70;
            deleteButton.UseColumnTextForButtonValue = true;
            this.dgRadnici.Columns.Add(deleteButton);          

            ComboBoxBrod.SelectedIndex = 0;
            List<Brod> listabrod = DBBrod.DohvatiBrodove(idKBroda);

            foreach (var a in listabrod)
            {
                ComboboxItem item = new ComboboxItem();              
                item.Text = a.Ime;
                item.Value = a.id;

                ComboBoxBrod.Items.Add(item);
            }

            radnikPrikaz = DBRadnik.DohvatiRadnike(idKBroda);

            var radniciPresenter = new ObservableCollection<RadnikPresenter>(RadnikPresenter.ToPresenter(radnikPrikaz));
            dgRadnici.DataSource = radniciPresenter;
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "Ne možete unijeti brojeve", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "Ne možete unijeti brojeve", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxOib_KeyPress(object sender, KeyPressEventArgs e)
        {            
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "Ne možete unijeti slova", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ButtonDodajradnika_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxIme.Text) || string.IsNullOrWhiteSpace(TextBoxPrezime.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Niste unijeli ime ili prezime radnika", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(TextBoxOib.Text) || TextBoxOib.Text.Length != 11)
            {
                MetroFramework.MetroMessageBox.Show(this, "Niste unijeli OIB radnika ili nije odgovarajuće dužine", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ComboBoxBrod.Text== "--odaberi brod--")
            {
                MetroFramework.MetroMessageBox.Show(this, "Niste odabrali brod", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                long id_broda = Convert.ToInt64((ComboBoxBrod.SelectedItem as ComboboxItem).Value.ToString());

                long idKBroda = WindowPrijavaRibara.IdKBroda;

                Radnik radnik = new Radnik();
                radnik.Ime = TextBoxIme.Text;
                radnik.Prezime = TextBoxPrezime.Text;
                radnik.Oib = TextBoxOib.Text;
                radnik.Id_Broda = id_broda;
                radnik.IDKBroda = idKBroda;
                TextBoxOib.Text = "";
                DBRadnik.DodajRadnik(radnik);

                MetroFramework.MetroMessageBox.Show(this, "Uspješno ste dodali novog radnika", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgRadnici.DataSource = null;
                radnikPrikaz = DBRadnik.DohvatiRadnike(idKBroda);
                var radniciPresenter = new ObservableCollection<RadnikPresenter>(RadnikPresenter.ToPresenter(radnikPrikaz));
                dgRadnici.DataSource = radniciPresenter;
            }

        }

        private void TextBoxOib_Leave(object sender, EventArgs e)
        {
            List<Radnik> listaRadnika = DBRadnik.DohvatiRadnike(idKBroda);
            Boolean postojeci_oib = false;
            foreach (var i in listaRadnika)
            {
                if (TextBoxOib.Text == i.Oib)
                {
                    postojeci_oib = true;
                    break;
                }
            }

            if (postojeci_oib)
            {
                MetroFramework.MetroMessageBox.Show(this, "Već postoji radnik sa unesenim OIB-om", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxOib.Text = "";
            }
        }

        private void ComboBoxBrod_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string s = "--odaberi brod--";
            if (ComboBoxBrod.Text != s)
            {
                ComboBoxBrod.Items.Remove(s);

            }
        }

        private void dgRadnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == dgRadnici.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgRadnici.Columns["dataGridViewDeleteButton"].Index)
            {
               
                var result = MetroFramework.MetroMessageBox.Show(this, "Jeste li sigurni da želite ukloniti radnika", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (result == DialogResult.Yes)
                {
                    this.radnikPrikaz.RemoveAt(e.RowIndex);
                    int id_radnika =Convert.ToInt32(dgRadnici.Rows[e.RowIndex].Cells[0].Value);

                    DBRadnik.IzbrisiRadnik(id_radnika);

                    dgRadnici.DataSource = null;
                    radnikPrikaz = DBRadnik.DohvatiRadnike(idKBroda);
                    var radniciPresenter = new ObservableCollection<RadnikPresenter>(RadnikPresenter.ToPresenter(radnikPrikaz));
                    dgRadnici.DataSource = radniciPresenter;
                }

            }
        }
    }
}
