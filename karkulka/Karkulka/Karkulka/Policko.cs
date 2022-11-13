using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karkulka
{
    public class Policko
    {
        private PolickoTyp typ;

        public PolickoTyp Typ
        {
            get { return typ; }
            set { typ = value; }
        }

        public Policko(PolickoTyp typ)
        {
            Typ = typ;
        }

        public override string? ToString()
        {
            string temp = "";
            switch (typ)
            {
                case PolickoTyp.BABICKA:
                    temp += "C ";
                    break;
                case PolickoTyp.VYHLIDKA:
                    temp += "0 ";
                    break;
                case PolickoTyp.DOMOV:
                    temp += "D ";
                    break;
                case PolickoTyp.KVETINOVA_LOUKA:
                    temp += "L ";
                    break;
                case PolickoTyp.PREKAZKA:
                    temp += "P ";
                    break;
                case PolickoTyp.VLK:
                    temp += "V ";
                    break;
                case PolickoTyp.BLUDNY_KOREN:
                    temp += "B ";
                    break;
            }
            return temp;
        }
    }
}
