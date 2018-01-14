using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probneKolo1
{
    class Program
    {    
        private static Katalog katalog = new Katalog("Katalog");

        static void Main(string[] args)
        {
            katalog.Test();
            while (true)
            {
                App_Menu();
                App_Switch();
                Console.Write("Wcisnij dowolny klawisz!");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void App_Menu()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("A - dodaj czasopismo");
            Console.WriteLine("B - dodaj ksiazke");
            Console.WriteLine("C - wyszukaj po tytule");
            Console.WriteLine("D - wyszukaj po id");
            Console.WriteLine("E - pokaz zawartosc");
            Console.WriteLine("X - wyjdz z aplikacji");
            Console.WriteLine("------------------------------");
        }
        static void App_Switch()
        {
            char znak;
            Console.WriteLine("Wpisz klawisz i wciśnij Enter:");
                znak = Convert.ToChar(Console.Read());
                switch (znak)
                {
                    case 'A':
                    case 'a':
                        katalog.Add_czasopismo();
                        break;

                    case 'B':
                        katalog.Add_ksiazka();
                        break;

                    case 'C':
                        Console.WriteLine("#------------------------------------------------------#");
                        katalog.Szukanie_po_tytul();
                        Console.WriteLine("#------------------------------------------------------#");
                        break;

                    case 'D':
                        Console.WriteLine("#------------------------------------------------------#");
                        katalog.Szukanie_po_id();
                        Console.WriteLine("#------------------------------------------------------#");
                        break;

                    case 'E':
                        Console.WriteLine("#------------------------------------------------------#");
                        katalog.WypiszWszystko();
                        Console.WriteLine("#------------------------------------------------------#");
                        break;

                    case 'X':
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Zły znak!");
                        break;
                }
        }
    }
}
