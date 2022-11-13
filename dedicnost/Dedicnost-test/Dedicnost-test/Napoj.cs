using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_test
{
    public class Napoj
    {
        private int cena;
        private string nazev;

        public Napoj(int cena, string nazev)
        {
            this.cena = cena;
            this.nazev = nazev;
        }

        public int Cena
        {
            get{ return cena; }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Cena nesmi byt mensi nez nula nebo nula");
                }
                this.cena = value;
            }
        }

        public string Nazev
        {
            get { return nazev; }
            set
            {
                if(value.Length < 3)
                {
                    throw new Exception("Napoj se musi mit jmeno delsi nez 3");
                }
                this.nazev = value;
            }
        }

        public override string? ToString()
        {
            return "Napoj: "+ nazev+", Cena: "+cena+"kc";
        }
    }
}
