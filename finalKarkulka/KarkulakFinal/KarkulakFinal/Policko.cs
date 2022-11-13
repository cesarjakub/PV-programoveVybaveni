using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarkulakFinal
{
    public class Policko
    {
        private Typ typ;
        private Karkulka karkulka;

        public Typ Typ
        {
            get { return typ; }
            set { typ = value; }
        }

        public Karkulka Karkulka
        {
            get { return karkulka; }
            set { karkulka = value; }
        }

        public Policko(Typ typ)
        {
            Typ = typ;
        }

        public override string? ToString()
        {
            if (Typ == Typ.DOMOV)
            {
                return "D ";
            }
            else if (Typ == Typ.LOUKA)
            {
                return "L ";
            }
            else if (Typ == Typ.BABICKA)
            {
                return "B ";
            }
            else if (Karkulka != null)
            {
                return "K ";
            }
            else if(Typ == Typ.BLUDNY_KOREN)
            {
                return "O ";
            }
            return "- ";
        }
    }
}
