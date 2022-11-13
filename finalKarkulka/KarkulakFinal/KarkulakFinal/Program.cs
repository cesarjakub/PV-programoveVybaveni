namespace KarkulakFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;


            GameLogic game = new GameLogic();
            int vyber = 0;
            Console.WriteLine("Výtejte ve hře Červená Karkulka!!");
            Console.WriteLine("Pravidla: ");
            Console.WriteLine("Úkolem je dostat se z DOMU \"D\" k BABIČCE \"B\".");
            Console.WriteLine("Po cestě na vás čekají nástrahy musí te se jim vyhnout.");
            Console.WriteLine("K babičce se musíte přinést košík s vínem a bábovkou.");
            Console.WriteLine("Když příjdete o bábovku nebo o víno můžete  \n"+
                              "zajít na louku kde kvítím nebo houbami nahrdíte ztracený předmět.\n" +
                              "Na louku může jen jednou!!!");
            Console.WriteLine("Hodně štěstí");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine("| Vysvětlení značek:                                               |");
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine("| 1)   Domov         Start karkulky                          \"D\" |");
            Console.WriteLine("| 2)   Louka         Na loce nazbíráte dárky po ztrátě       \"L\" |");
            Console.WriteLine("| 3)   BABICKA       Cílová destinace                        \"B\" |");
            Console.WriteLine("| 4)   KARKULKA      Hráč                                    \"K\" |");
            Console.WriteLine("| 5)   BLUDNY_KOREN  Prenese vás na náhodné místo            \"O\" |");
            Console.WriteLine("| 6)   VYHLIDKA      Zde se může ukrývat cokoliv             \"-\" |");
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            do
            {
                Console.WriteLine("+-----------------------------------------------+");
                Console.WriteLine("| No:  Nazev:  popis:                           |");
                Console.WriteLine("+-----------------------------------------------+");
                Console.WriteLine("| 1)   Mapa      Vypiše mapu                    |");
                Console.WriteLine("| 2)   Doleva    karkulka se pohne doleva       |");
                Console.WriteLine("| 3)   Doprava   karkulka se pohne doprava      |");
                Console.WriteLine("| 4)   Dolu      karkulka se pohne dolu         |");
                Console.WriteLine("| 5)   Nahoru    karkulka se pohne nahoru       |");
                Console.WriteLine("| 6)   inventory Vypíše cp má karkulka u sebe   |");
                Console.WriteLine("| 7)   konec     ukončí to hru                  |");
                Console.WriteLine("+-----------------------------------------------+");
                Console.Write("Vyberte si moznost 1-7: ");
                vyber = int.Parse(Console.ReadLine());
                Console.WriteLine("+-----------------------------------------------+");
                if (vyber == 1)
                {
                    Console.WriteLine();
                    game.vypis();
                    Console.WriteLine();
                }
                if(vyber == 2)
                {
                    Console.WriteLine();
                    game.pohniSe(Smer.VLEVO);
                    Console.WriteLine("Karkulak se pohla doleva");
                    Console.WriteLine();
                    game.vypis();
                    Console.WriteLine();
                    game.checkWhereIam();
                    game.inventory();
                }
                if (vyber == 3)
                {
                    Console.WriteLine();
                    game.pohniSe(Smer.VPRAVO);
                    Console.WriteLine("Karkulak se pohla doprava");
                    Console.WriteLine();
                    game.vypis();
                    Console.WriteLine();
                    game.checkWhereIam();
                    game.inventory();
                }
                if (vyber == 4)
                {
                    Console.WriteLine();
                    game.pohniSe(Smer.DOLU);
                    Console.WriteLine("Karkulak se pohla dolu");
                    Console.WriteLine();
                    game.vypis();
                    Console.WriteLine();
                    game.checkWhereIam();
                    game.inventory();
                }
                if (vyber == 5)
                {
                    Console.WriteLine();
                    game.pohniSe(Smer.NAHORU);
                    Console.WriteLine("Karkulak se pohla nahoru");
                    Console.WriteLine();
                    game.vypis();
                    Console.WriteLine();
                    game.checkWhereIam();
                    game.inventory();
                }
                if (vyber == 6)
                {
                    Console.WriteLine();
                    game.inventory();
                    Console.WriteLine();

                }
            } while (vyber != 7);

        }
    }
}