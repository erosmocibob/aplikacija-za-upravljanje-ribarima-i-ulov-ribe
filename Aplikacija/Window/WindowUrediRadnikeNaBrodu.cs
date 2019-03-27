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

namespace Aplikacija
{
    public partial class WindowUrediRadnikeNaBrodu : MetroFramework.Forms.MetroForm
    {
        public List<Brod> brodPrikaz;
        public List<Radnik> radnikPrikaz;
        public WindowUrediRadnikeNaBrodu()
        {
            InitializeComponent();          
        }
        private void UpdateForm()
        {
            comboBoxRadnik.Items.Clear();
            List<Radnik> listaRadnik = DBRadnik.DohvatiRadnikeNull();

            foreach (var a in listaRadnik)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = a.Ime + " " + a.Prezime;
                item.Value = a.id;

                comboBoxRadnik.Items.Add(item);
            }
        }

        private void WindowUrediRadnikeNaBrodu_Load(object sender, EventArgs e)
        {
            long IdBroda = WindowUnosBroda.IdBroda;

            brodPrikaz = DBBrod.DohvatiBrodoveID(IdBroda);
            var brodoviPresenter = new ObservableCollection<BrodPresenter>(BrodPresenter.ToPresenter(brodPrikaz));
            dbBrod.DataSource = brodoviPresenter;

            radnikPrikaz = DBRadnik.DohvatiRadnikeID(IdBroda);

            var radnikPresenter = new ObservableCollection<RadnikPresenter>(RadnikPresenter.ToPresenter(radnikPrikaz));
            dgRandnik.DataSource = radnikPresenter;

            List<Radnik> listaRadnik = DBRadnik.DohvatiRadnikeNull();

            foreach (var a in listaRadnik)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = a.Ime + " " + a.Prezime;
                item.Value = a.id;

                comboBoxRadnik.Items.Add(item);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxRadnik.Text) ||comboBoxRadnik.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Nemate odabranog niti jednog radnika ili nemate niti jednog dostupnog radnika", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long IdBroda = WindowUnosBroda.IdBroda;

                long id_broda = Convert.ToInt64((comboBoxRadnik.SelectedItem as ComboboxItem).Value.ToString());
                DBRadnik.UpdateRadnikBrod(IdBroda, id_broda);

                MetroFramework.MetroMessageBox.Show(this, "Uspješno ste dodali novog radnika na brodu", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                radnikPrikaz = DBRadnik.DohvatiRadnikeID(IdBroda);

                var radnikPresenter = new ObservableCollection<RadnikPresenter>(RadnikPresenter.ToPresenter(radnikPrikaz));
                dgRandnik.DataSource = radnikPresenter;

                 comboBoxRadnik.Text = "";

                UpdateForm();
            }

        }

        private void dgRandnik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgRandnik.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgRandnik.Columns["ukloniRadnika"].Index)
            {              

                if (MetroFramework.MetroMessageBox.Show(this, @"Jeste li sigurni da želite radnika sa broda.",
                        "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {                  
                 
                    long id_radnik = (long)dgRandnik.Rows[e.RowIndex].Cells[0].Value;  
                    DBRadnik.RandnikIsNull(id_radnik);

                    MetroFramework.MetroMessageBox.Show(this, "Uspješno ste uklonili radnika sa broda", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    long IdBroda = WindowUnosBroda.IdBroda;
                    radnikPrikaz = DBRadnik.DohvatiRadnikeID(IdBroda);

                    var radnikPresenter = new ObservableCollection<RadnikPresenter>(RadnikPresenter.ToPresenter(radnikPrikaz));
                    dgRandnik.DataSource = radnikPresenter;

                    UpdateForm();
                }
                else
                {
                    return;
                }              
            }
                                          
        }

    }
}
