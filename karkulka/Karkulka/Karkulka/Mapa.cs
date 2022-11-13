using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karkulka
{
    public class Mapa
    {
        private Policko[,] pole;
        private int x;
        private int y;
        private Karkulka karkulka;

        public Karkulka Karkulka 
        { 
            get { return karkulka; }
            set { karkulka = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Mapa(Karkulka karkulka)
        {
            pole = new Policko[16, 16];
            Karkulka = karkulka;
        }

        public void DumKar()
        {
            Random rand = new Random();
            int z = rand.Next(0, 16);
            int c = rand.Next(0, 16);
            pole[z, c].Typ = PolickoTyp.DOMOV;
            Console.WriteLine(pole[z, c].Typ + z +" " + c);
        }

        public void vypisPole()
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for(int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = new Policko(PolickoTyp.VYHLIDKA);
                    Console.Write(pole[i, j]);
                }
                Console.WriteLine();
            }
            DumKar();
        }

    }
}
