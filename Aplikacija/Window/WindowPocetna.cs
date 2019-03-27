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
    public partial class Form1 : MetroFramework.Forms.MetroForm 
    {
        public Form1()
        {
            InitializeComponent();            
        }
        
        private void Unosulova_Click(object sender, EventArgs e)
        {
            var unosulovaWin = new WindowUnosUlova();            
            unosulovaWin.ShowDialog();            
        }

        private void buttonRadnici_Click(object sender, EventArgs e)
        {
            var radniciWin = new WindowUnosRadnika();
            radniciWin.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var unosbrodaWin = new WindowUnosBroda();
            unosbrodaWin.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            var povUlovaRadnikaWind = new WindowPovijestUlovaRadnika();
            povUlovaRadnikaWind.ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var povUlovaRadnikaWind = new WindowPrijava();
            povUlovaRadnikaWind.Hide() ;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            string informacije = File.ReadAllText(@"..\..\informacije.txt", Encoding.UTF8);
            label1.Text = informacije;
        }
    }
}
