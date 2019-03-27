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


namespace Aplikacija
{
    public partial class WindowPrijava : MetroFramework.Forms.MetroForm
    {
        public WindowPrijava()
        {
            InitializeComponent();
        }

        private void buttonRibar_Click(object sender, EventArgs e)
        {            
            var prijavaRibaraWin = new WindowPrijavaRibara();
            this.Hide();
            prijavaRibaraWin.ShowDialog();
            this.Close();
        }

        private void buttonZaposlenikuprave_Click(object sender, EventArgs e)
        {
            this.Hide();
            var prijavaZapDrzWin = new WindowPrijavaZapDrzave();
            prijavaZapDrzWin.ShowDialog();
            this.Close();
        }

        private void WindowPrijava_Load(object sender, EventArgs e)
        {           

        }
    }
}
