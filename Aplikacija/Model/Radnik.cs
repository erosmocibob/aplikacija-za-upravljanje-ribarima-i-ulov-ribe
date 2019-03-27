using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    public class Radnik
    {
        public long? id { get; set; }
        private string ime;
        private string prezime;
        private string oib;
        private long id_broda;
        private string ime_broda;
        private long id_KBroda;

        public Radnik() { }

        public Radnik(string ime, string prezime, string oib, long id_broda, long id_kbrod)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Oib = oib;
            this.Id_Broda = id_broda;
            this.IDKBroda = id_kbrod;
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

        public long Id_Broda
        {
            get
            {
                return id_broda;
            }
            set
            {
                id_broda = value;
            }
        }

        public string Ime_Broda
        {
            get
            {
                return ime_broda;
            }
            set
            {
                ime_broda = value;
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
