﻿using System;
using System.Collections.Generic;
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
    public partial class WindowPrijavaZapDrzave : MetroFramework.Forms.MetroForm 
    {
        public WindowPrijavaZapDrzave()
        {
            InitializeComponent();
            TextBoxSifra.UseSystemPasswordChar = true;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var prijavaWin = new WindowPrijava();
            prijavaWin.ShowDialog();
            this.Close();
        }       

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (metroCheckBox1.Checked)
            {
                TextBoxSifra.UseSystemPasswordChar = false;
            }
            else
            {
                TextBoxSifra.UseSystemPasswordChar = true;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        { 
            bool uspjesnaprijava = DBKapetanBroda.prijavaKBroda(TextBoxIme.Text, TextBoxSifra.Text);
            if (uspjesnaprijava == true)
            {
                this.Hide();
                var pocetnaWin = new WindowPocetnaZapDrzv();
                pocetnaWin.ShowDialog();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Niste unijeli točnu korisičko ime ili šifru pokušajte ponovno", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
