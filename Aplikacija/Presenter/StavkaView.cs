using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija //.Presenter
{
    //class StavkaView
  //  {
   // }

    class StavkaPresenter
    {
       public static List<StavkaPresenter> ToPresenter(List<UlovStavka> stavke)
       {
            var stavkePresenter = new List<StavkaPresenter>();
            foreach(var s in stavke)
            {
                stavkePresenter.Add(new StavkaPresenter(s));
            }
             return stavkePresenter;
       }


        UlovStavka model;

        public StavkaPresenter(UlovStavka stavka)
        {
            this.model = stavka;
        }

        public string Naziv
        {
            get
            {
                return model.Riba.Naziv;
                
            }
        }


        public string Kolicina
        {
            get
            {
                return model.Kolicina.ToString("#.## kg");
            }
        }       


    }     

}
