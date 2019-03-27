using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    public class Riba
    {
        public long? id { get; set; }
        private String naziv;
        private long id_ribe;

        public Riba() { }

        public Riba(string riba_naziv,long id_ribe)
        {
            this.Naziv = riba_naziv;
            this.Id_ribe = id_ribe;
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public long Id_ribe
        {
            get
            {
                return id_ribe;
            }

            set
            {
                id_ribe = value;
            }
        }

    }
}
