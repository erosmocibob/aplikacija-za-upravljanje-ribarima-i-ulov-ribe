using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    public class KapetanBroda
    {

        public long? id { get; set; }
        private string ime;
        private string prezime;
        private string sifra;
        private string oib;

        public KapetanBroda(string ime, string prezime, string sifra, string oib)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Sifra = sifra;
            this.Oib = oib;          
        }

        public KapetanBroda() { }

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

        public string Oib
        {
            get
            {
                return oib;
            }
            set
            {
                oib = value;
            }
        }

    }
}
