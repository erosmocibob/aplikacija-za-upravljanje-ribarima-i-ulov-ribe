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
    public partial class WindowUnosBroda : MetroFramework.Forms.MetroForm
    {   public long idKBroda = WindowPrijavaRibara.IdKBroda;
        public List<Brod> brodPrikaz;
        public static long IdBroda;

        public WindowUnosBroda()
        {
            InitializeComponent();

            TextBoxRegOznaka.MaxLength = 6;
            TextBoxRegOznaka.ForeColor = Color.Gray;
            TextBoxRegOznaka.Text = "npr. PU-243";
            TextBoxImeBroda.MaxLength = 20;
        }

        private void WindowUnosBroda_Load(object sender, EventArgs e)
        {     
            var deleteButton = new DataGridViewButtonColumn();

            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Obriši";
            deleteButton.Text = "Delete";
            deleteButton.Width = 70;
            deleteButton.UseColumnTextForButtonValue = true;
            this.dgBrodovi.Columns.Add(deleteButton);
            
            long idKBroda = WindowPrijavaRibara.IdKBroda;

            ComboBoxVrstaBroda.SelectedIndex = 0;
            brodPrikaz = DBBrod.DohvatiBrodove(idKBroda);

            var brodoviPresenter = new ObservableCollection<BrodPresenter>(BrodPresenter.ToPresenter(brodPrikaz));
            dgBrodovi.DataSource = brodoviPresenter;
        }

        private void ComboBoxVrstaBroda_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "--odaberi vrstu--";
            if (ComboBoxVrstaBroda.Text != s)
            {
                ComboBoxVrstaBroda.Items.Remove(s);
            }
        }

        private void ButtonDodajBrod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxRegOznaka.Text) || TextBoxRegOznaka.Text == "npr. PU-243")
            {
                MetroFramework.MetroMessageBox.Show(this, "Niste unijeli regstracijsku oznaku broda", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrWhiteSpace(TextBoxImeBroda.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Niste unijeli ime broda", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

            else if(ComboBoxVrstaBroda.Text == "--odaberi vrstu--")
            {
                MetroFramework.MetroMessageBox.Show(this, "Niste odabrali vrstu broda", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Brod novibrod = new Brod(TextBoxImeBroda.Text, TextBoxRegOznaka.Text, ComboBoxVrstaBroda.Text, idKBroda);
                
                DBBrod.DodajBrod(novibrod);
                MetroFramework.MetroMessageBox.Show(this, "Uspješno ste dodali novi brod", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgBrodovi.DataSource = null;
                brodPrikaz = DBBrod.DohvatiBrodove(idKBroda);
                var brodoviPresenter = new ObservableCollection<BrodPresenter>(BrodPresenter.ToPresenter(brodPrikaz));
                dgBrodovi.DataSource = brodoviPresenter;
            }

        }    

        private void TextBoxImeBroda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "Možete unijeti samo slova", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }               

        private void TextBoxRegOznaka_Leave(object sender, EventArgs e)
        {
            List<Brod> listaBrodova = DBBrod.DohvatiBrodove(idKBroda);
            Boolean post_reg = false;
            foreach (var i in listaBrodova)
            {
                if (TextBoxRegOznaka.Text == i.Reg_Ozn)
                {
                    post_reg = true;
                    break;
                }
            } 

            if (TextBoxRegOznaka.Text.Trim() == "" || TextBoxRegOznaka.Text.Length <= 5 || TextBoxRegOznaka.Text.Contains("-") == false)
            {
                TextBoxRegOznaka.Text = "npr. PU-243";
                TextBoxRegOznaka.ForeColor = Color.Gray;
            }
            else if (post_reg)
            {
                MetroFramework.MetroMessageBox.Show(this, "Već postoji brod sa unesenom registracijskom oznakom", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxRegOznaka.Text = "";
            }
        }

        private void TextBoxRegOznaka_Click(object sender, EventArgs e)
        {
            TextBoxRegOznaka.Text = "";
        }

        private void TextBoxRegOznaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxRegOznaka.ForeColor = Color.Black;
        }

        private void dgBrodovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgBrodovi.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgBrodovi.Columns["imeDataGridViewTextBoxColumn"].Index)
            {
                long id_brodaRadnik = (long)dgBrodovi.Rows[e.RowIndex].Cells[0].Value;
                IdBroda = (long)dgBrodovi.Rows[e.RowIndex].Cells[0].Value;
                var urediradnikenabroduWin = new WindowUrediRadnikeNaBrodu();
                urediradnikenabroduWin.ShowDialog();
            }

            if (e.ColumnIndex == dgBrodovi.Columns["dataGridViewDeleteButton"].Index)
            {

                long id_broda= (long)dgBrodovi.Rows[e.RowIndex].Cells[0].Value;             
               
                if (DBBrod.provjeraBrodRadnik(id_broda) == false)
                {
                    if(MetroFramework.MetroMessageBox.Show(this, @"Jeste li sigurni da želite ukloniti brod. Brod sadrži radnike i radnici će biti uklonjeni sa broda",
                            "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        DBBrod.IzbrisiBrodUpdateRadnik(id_broda);

                        MetroFramework.MetroMessageBox.Show(this, "Uspješno ste uklnonili bord i uklonili radnike s broda", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgBrodovi.DataSource = null;
                        brodPrikaz = DBBrod.DohvatiBrodove(idKBroda);
                        var brodoviPresenter = new ObservableCollection<BrodPresenter>(BrodPresenter.ToPresenter(brodPrikaz));
                        dgBrodovi.DataSource = brodoviPresenter;
                    }
                    else
                    {
                        return;
                    }  

                }
                else if(DBBrod.provjeraBrodRadnik(id_broda) == true) 
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Jeste li sigurni da želite ukloniti brod", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        this.brodPrikaz.RemoveAt(e.RowIndex);
                        DBBrod.IzbrisiBrod(id_broda);

                        dgBrodovi.DataSource = null;
                        brodPrikaz = DBBrod.DohvatiBrodove(idKBroda);
                        var brodoviPresenter = new ObservableCollection<BrodPresenter>(BrodPresenter.ToPresenter(brodPrikaz));
                        dgBrodovi.DataSource = brodoviPresenter;

                    }
                }

            }
        }

        private void dgBrodovi_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Button btn = new Button();
            dgBrodovi.Rows[0].Cells[1].Value = new Button();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
