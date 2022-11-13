using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni1710Slovik
{
    public class Slovo
    {
        private List<string> slova = new List<string>();

        public List<string> Slova
        {
            get { return slova; }
            set { slova = value; }
        }

        public Slovo(List<string> slova)
        {
            Slova = slova;
        }

        public override string ToString()
        {
            string vypis = "";
            foreach (string s in Slova)
            {
                vypis += s+" ";
            }
            return vypis;
        }
    }
}
