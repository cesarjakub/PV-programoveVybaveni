using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1209tridy
{
    internal class Potravina
    {
        private string nazev;
        private int hmotnost; //100g
        private float enHod; //1500 kcal

        public Potravina(string nazev, int hmotnost, float enHod)
        {
            this.nazev = nazev;
            this.hmotnost = hmotnost;
            this.enHod = enHod;
        }

        public string Nazev
        {
            get { return nazev; }
            set { nazev = value; }
        }

        public int Hmotnost
        {
            get { return hmotnost; }
            set 
            {
                if(value < 0)
                {
                    value = 100;
                }
                hmotnost = value;
            }   
        }  

        public float EnHod
        {
            get { return enHod; }
            set
            {
                if (value < 0)
                {
                    value = 100;
                }
                enHod = value;
            }
        }


        public float KcalToKj()
        {
            return enHod * 4.18f;
        }

        public float procenta()
        {
            return enHod / (1500/100);
        }

        public override string? ToString()
        {
            return nazev+": "+hmotnost+"g, "+enHod+"Kcal";
        }
    }
}
