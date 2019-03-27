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
    public partial class WindowPocetnaZapDrzv : MetroFramework.Forms.MetroForm
    
    {
        public WindowPocetnaZapDrzv()
        {
            InitializeComponent();
        }

        private void ButtonIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WindowPocetnaZapDrzv_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var newform = new WindowUrediInf();
            newform.ShowDialog();
        }

        private void ButtonPodUlov_Click(object sender, EventArgs e)
        {
            var newform = new WindowPovijestUlova();
            newform.ShowDialog();
        }

        private void WindowPocetnaZapDrzv_Activated(object sender, EventArgs e)
        {
            string informacije = File.ReadAllText(@"..\..\informacije.txt", Encoding.UTF8);
            label1.Text = informacije;
        }
    }
}
