using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    public class UlovStavka
    {
        public long? id { get; set; }
        private double kolicina;
        private Riba riba;
        private long id_ulova;         

        public UlovStavka() { }

        public UlovStavka(double kolicina, Riba riba, long id_ulova)
        {            
            this.Kolicina = kolicina;
            this.Riba = riba;
            this.Id_ulova = id_ulova;        
        }

        public UlovStavka(double kolicina, Riba riba)
        {
            this.Kolicina = kolicina;
            this.Riba = riba;            
        }

        public UlovStavka(long id_ulova)
        {
            this.Id_ulova = id_ulova;           
        }

        public double Kolicina
        {
            get
            {
                return kolicina;
            }

            set
            {
                kolicina = value;
            }
        }


        public Riba Riba
        {
            get
            {
                return riba;
            }

            set
            {
                riba = value;
            }
        }

        public long Id_ulova
        {
            get
            {
                return id_ulova;
            }

            set
            {
                id_ulova = value;
            }
        }

    }
}
