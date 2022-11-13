using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarkulakFinal
{
    public class Karkulka
    {
        private bool vino = true;
        private bool babovka = true;

        public bool Babovka
        {
            get { return babovka; }
            set { babovka = value; }
        }

        public bool Vino
        {
            get { return vino; }
            set { vino = value; }
        }

        public Karkulka()
        {

        }

        public override string? ToString()
        {
            return "";
        }
    }
}
