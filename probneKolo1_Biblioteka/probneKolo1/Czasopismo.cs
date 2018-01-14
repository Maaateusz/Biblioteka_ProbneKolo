using System;

namespace probneKolo1
{
    class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo() { }
        public Czasopismo(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.numer = numer;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine(this.tytul+ " " + this.wydawnictwo + " " + this.id + " " + this.rokWydania + "r. " + this.numer);
        }
    }
}
