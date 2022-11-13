using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karkulka
{
    public class Game
    {
        private Karkulka karkulka;
        private Mapa mapa;

        public Game()
        {
            intiClasses();
        }

        public void intiClasses()
        {
            karkulka = new Karkulka();
            mapa = new Mapa(karkulka);
        }

        public void gameLoop()
        {
            int vyber = 0;
            do
            {
                Console.WriteLine("Nu.   Nazev        Popis ");
                Console.WriteLine("+-----------------------------------------------+");
                Console.WriteLine("| 1)  Vypsni pole  vypise pole do konzole       |");
                Console.WriteLine("| 2)  Jít doleva   vydate se karkulkou doleva   |");
                Console.WriteLine("| 3)  Jít doprava  vydate se karkulkou doprava  |");
                Console.WriteLine("| 4)  Jít dolu     vydate se karkulkou dolu     |");
                Console.WriteLine("| 5)  Jít nahoru   vydate se karkulkou nahoru   |");
                Console.WriteLine("| 6)  Konec        ukopnčíte hru napsáním 6     |");
                Console.WriteLine("+-----------------------------------------------+");
                Console.WriteLine("Napiste bud cisla 1-6");
                Console.Write("Vyberte si moznost: ");
                vyber = Int32.Parse(Console.ReadLine());
                if (vyber == 1)
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine();
                    mapa.vypisPole();
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------");
                }
                if (vyber == 2)
                {
                    pohybujSe(Smer.VLEVO);
                }
                if (vyber == 3)
                {
                    pohybujSe(Smer.VPRAVO);
                }
                if (vyber ==  4)
                {
                    pohybujSe(Smer.DOLU);
                }
                if (vyber == 5)
                {
                    pohybujSe(Smer.NAHORU);
                }
            }
            while (vyber != 6);
        }


        public void pohybujSe(Smer smer)
        {
            switch (smer)
            {
                case Smer.NAHORU:
                    break;
                case Smer.DOLU:
                    break;
                case Smer.VLEVO:
                    break;
                case Smer.VPRAVO:
                    break;
            }
        }
    }
}
