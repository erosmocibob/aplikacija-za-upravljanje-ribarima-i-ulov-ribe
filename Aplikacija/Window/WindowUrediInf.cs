using System;
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
using System.IO;


namespace Aplikacija
{
    public partial class WindowUrediInf : MetroFramework.Forms.MetroForm
    {
        public WindowUrediInf()
        {
            InitializeComponent();
        }

        private void WindowUrediInf_Load(object sender, EventArgs e)
        {
            string informacije = File.ReadAllText(@"..\..\informacije.txt", Encoding.UTF8);
            richTextBox1.Text = informacije;
            label1.Text = richTextBox1.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = richTextBox1.Text;
        }

        private void ButtonSpremi_Click(object sender, EventArgs e)
        {
            string noveInformacije = richTextBox1.Text;
            File.WriteAllText(@"..\..\informacije.txt", noveInformacije, Encoding.UTF8);

            MetroFramework.MetroMessageBox.Show(this, "Uspješno ste spremili nove inofmacije", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void ButtonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
