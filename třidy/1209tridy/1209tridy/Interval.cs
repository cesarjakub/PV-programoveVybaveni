using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1209tridy
{
    internal class Interval
    {
        private int horni;
        private int dolni;

        public Interval(int horni, int dolni)
        {
            this.horni = horni;
            this.dolni = dolni;
        }

        public int Horni 
        { 
            get { return horni; } 
            set {
                if(value < dolni)
                {
                    throw new Exception("ERROR");
                }
                horni = value;
              }  
        }

        public int Dolni
        {
            get { return dolni; }
            set
            {
                if(value > horni)
                {
                    throw new Exception("ERROR");
                }
                dolni = value;
            }
        }

        public bool nachaziSe(int cislo)
        {
            if (cislo >= dolni && cislo <= horni)
            {
                return true;
            }
            return false;
        }

        public string? prunik(Interval inter)
        {
            for (int i = dolni; i <= horni; i++)
            {
                for (int j = inter.dolni; j <= inter.horni; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine("prunik "+i+" -- "+j);
                    }
                }
            }
            return "null" ;
        }

    }
}
