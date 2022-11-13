using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1209tridy
{
    internal class Primka
    {
        private int pocatek;
        private int konec;

        public Primka(int pocatek, int konec)
        {
            this.pocatek = pocatek;
            this.konec = konec;
        }

        public int Pocatek
        {
            get { return pocatek; }
            set
            {
                if(value > konec)
                {
                    throw new Exception("ERROR");
                }
                pocatek = value;
            }
        }

        public int Konec
        {
            get { return konec; }
            set
            {
                if(value < pocatek)
                {
                    throw new Exception("ERROR");
                }
                konec = value;
            }
        }


        public void DelkaPrimky()
        {
            for (int i = pocatek; i <= konec; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("Primka je dlouha: "+ konec);
        }

    }
}
