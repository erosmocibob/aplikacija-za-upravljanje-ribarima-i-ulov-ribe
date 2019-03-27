using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    public class Brod
    {
        public long? id { get; set; }
        private string ime;
        private string reg_oznaka;
        private string vrsta;
        private long id_KBroda;

        public Brod() { }

        public Brod(string ime, string reg_oznaka, string vrsta, long id_kpbroda)
        {
            this.Ime = ime;
            this.Reg_Ozn = reg_oznaka;
            this.Vrsta = vrsta;
            this.IDKBroda = id_kpbroda;
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }


        public string Reg_Ozn
        {
            get
            {
                return reg_oznaka;
            }

            set
            {
                reg_oznaka = value;
            }
        }

        public string Vrsta
        {
            get
            {
                return vrsta;
            }

            set
            {
                vrsta = value;
            }
        }

        public long IDKBroda
        {
            get
            {
                return id_KBroda;
            }
            set
            {
                id_KBroda = value;
            }
        }

    }
}
