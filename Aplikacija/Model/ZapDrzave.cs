using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    public class ZapDrzave
    {
        public long? id { get; set; }
        private string ime;
        private string prezime;
        private string sifra;

        public ZapDrzave(string ime, string prezime, string sifra)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Sifra = sifra;
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

        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }

        }

        public string Sifra
        {
            get
            {
                return sifra;
            }
            set
            {
                sifra = value;
            }
        }      

    }
}
