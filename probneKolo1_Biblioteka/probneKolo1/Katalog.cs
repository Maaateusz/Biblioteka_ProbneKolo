using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probneKolo1
{
    class Katalog : IZarzadzanie
    {
        string dzialTematyczny;
        List<Pozycja> pozycje = new List<Pozycja>();

        //public Katalog() { }
        public Katalog(string dzialTematyczny) { this.dzialTematyczny = dzialTematyczny; }

        public void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, string autorImie, string autorNazwisko)
        {
            pozycje.Add(new Ksiazka(tytul, id, wydawnictwo, rokWydania, liczbaStron, autorImie, autorNazwisko));
        }

        public void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
        {
            pozycje.Add(new Czasopismo(tytul, id, wydawnictwo, rokWydania, numer));
        }

        public void WypiszWszystko()
        {
            foreach(Pozycja element in pozycje)
            {
                element.WypiszInfo();
            }
        }

        public void WyszukajPoTytule(string tytul)
        {
            int licz = 0;
            foreach (Pozycja zList in pozycje)
            {
                if (tytul == zList.PobierzTytul())
                {
                    zList.WypiszInfo();
                    licz++;
                }
            }
            if (licz == 0)
            {
                Console.WriteLine("Nie znaleziono pozycji o podanym tytule");
            }
        }

        public void WyszukajPoId(int id)
        {
            int licz = 0;
            foreach (Pozycja zList in pozycje)
            {
                if (id == zList.PobierzId())
                {
                    zList.WypiszInfo();
                    licz++;
                }
            }
            if (licz == 0)
                Console.WriteLine("Nie znaleziono pozycji o podanym ID");
        }

        public void Test()
        {
            DodajPozycje("Gazeta Olsztyńska", 200, "Edytor", 1992, 7);
            DodajPozycje("Gazeta Wyborcza", 123, "Agora", 2010, 23);
            DodajPozycje("Krzyżacy", 220, "Znak", 2010, 300, "Henryk", "Sienkiewicz");
            DodajPozycje("Krzyżacy", 221, "Znak", 2011, 298, "Henryk", "Sienkiewicz");
        }

        public void Add_ksiazka()
        {
            string tytul;
            string wydawnictwo;
            string imie;
            string nazwisko;
            int rokWydania;
            int liczbaStron;
            int id;
            Console.WriteLine("Podaj tytuł: ");
            tytul = Console.ReadLine();
            Console.WriteLine("Podaj Imie autora: ");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj Nazwisko autora: ");
            nazwisko = Console.ReadLine();
            Console.WriteLine("wydawnictwo: ");
            wydawnictwo = Console.ReadLine();
            Console.WriteLine("Podaj rok wydania: ");
            rokWydania = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę stron: ");
            liczbaStron = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            DodajPozycje(tytul, id, wydawnictwo, rokWydania, liczbaStron, imie, nazwisko);
            Console.WriteLine("Książka została dodana!");
        }

        public void Add_czasopismo()
        {
            string tytul;
            string wydawnictwo;
            int rokWydania;
            int numer;
            int id;
            Console.WriteLine("Podaj tytuł: ");
            tytul = Console.ReadLine();
            Console.WriteLine("wydawnictwo: ");
            wydawnictwo = Console.ReadLine();
            Console.WriteLine("Podaj rok wydania: ");
            rokWydania = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj numer: ");
            numer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            DodajPozycje(tytul, id, wydawnictwo, rokWydania, numer);
            Console.WriteLine("Czasopismo zostało dodane!");
        }

        public void Szukanie_po_id()
        {
            int id;
            Console.Write("Podaj id: ");
            id = Convert.ToInt32(Console.ReadLine());
            WyszukajPoId(id);
        }

        public void Szukanie_po_tytul()
        {
            string tytul;
            Console.Write("Podaj tytul: ");
            tytul = Console.ReadLine();
            WyszukajPoTytule(tytul);
        }
    }
}
