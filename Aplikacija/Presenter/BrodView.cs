using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    class BrodPresenter
    {
        public static List<BrodPresenter> ToPresenter(List<Brod> stavka)
        {
            var brodPresenter = new List<BrodPresenter>();
            foreach (var s in stavka)
            {
                brodPresenter.Add(new BrodPresenter(s));
            }
            return brodPresenter;
        }


        Brod model;



        public BrodPresenter(Brod stavka)
        {
            this.model = stavka;
        }


        public long? ID
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


        public string Reg_Oznaka
        {
            get
            {
                return model.Reg_Ozn;
            }
        }
        public string Vrsta
        {
            get
            {
                return model.Vrsta;
            }
        }


    }
}
