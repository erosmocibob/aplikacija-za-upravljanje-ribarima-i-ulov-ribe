using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    class RadnikPresenter
    {
        public static List<RadnikPresenter> ToPresenter(List<Radnik> stavka)
        {
            var radnikPresenter = new List<RadnikPresenter>();
            foreach (var s in stavka)
            {
                radnikPresenter.Add(new RadnikPresenter(s));
            }
            return radnikPresenter;
        }


        Radnik model;

        public RadnikPresenter(Radnik stavka)
        {
            this.model = stavka;
        }


        public long? Id
        {
            get
            {
                return model.id;

            }
        }



        public string Ime
        {
            get
            {
                return model.Ime;

            }
        }


        public string Prezime
        {
            get
            {
                return model.Prezime;
            }
        }

        public string Ime_Broda
        {
            get
            {
                return model.Ime_Broda;
            }
        }

    }
}
