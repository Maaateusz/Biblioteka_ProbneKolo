using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probneKolo1
{
    class Autor
    {
        protected string imie;
        protected string nazwisko;

        public Autor() { }
        public Autor(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public object WypiszInfo()
        {
            return imie + " " + nazwisko;
        }
    }
}
