using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    public class Ulov
    {
        public long? id { get; set; }
        private DateTime datum;
        private string pocetak_vrijeme;
        private string kraj_vrijeme;
        private long id_brod;
        private List<UlovStavka> ulovlist = new List<UlovStavka>();
        private long id_KBroda;
      

        public Ulov(DateTime datum, List<UlovStavka> ulov)
        {
            this.Datum = datum;
            this.UlovList = ulov;
        }

        public Ulov(DateTime datum, string poc_lova, string k_vrijeme, long idbrod, long id_kbrod)
        {
            this.Datum = datum;
            this.Pocetak_vrijeme = poc_lova;
            this.Kraj_vrijeme = k_vrijeme;
            this.IDBrod = idbrod;
            this.IDKBroda = id_kbrod;
        }

        public Ulov() { }

        public Ulov(DateTime datum)
        {
            this.Datum = datum;
        }

        public long IDBrod
        {
            get
            {
                return id_brod;
            }

            set
            {
                id_brod = value;
            }
        }
        

        public DateTime Datum
        {
            get
            {
                return datum;
            }
            set
            {
                datum = value;
            }
        }

        public List<UlovStavka> UlovList
        {
            get
            {
                return ulovlist;   
            }

            set
            {
                ulovlist = value;
            }
        }       

        public string Pocetak_vrijeme
        {
            get
            {
                return pocetak_vrijeme;
            }
            set
            {
                pocetak_vrijeme = value;
            }
        }

        public string Kraj_vrijeme
        {
            get
            {
                return kraj_vrijeme;
            }
            set
            {
                kraj_vrijeme = value;
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

        public void DodajStavku(UlovStavka stavka)
        {
            UlovList.Add(stavka);

        }

    }
}
