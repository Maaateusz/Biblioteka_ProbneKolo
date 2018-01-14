using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probneKolo1
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        private Autor autor;

        public Ksiazka() { }
        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, string imie, string nazwisko)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.liczbaStron = liczbaStron;
            this.autor = new Autor(imie.Trim(), nazwisko.Trim());
        }
        public override void WypiszInfo()
        {
            Console.WriteLine(tytul + " " + wydawnictwo + " " + id + " " + rokWydania + "r. " + liczbaStron + " str. "+ autor.WypiszInfo());
        }
    }
}
