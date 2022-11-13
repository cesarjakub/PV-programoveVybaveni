using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni1710Slovik
{
    public class Slovnik
    {

        private Dictionary<Slovo, Slovo> dic = new Dictionary<Slovo, Slovo>();

        public Dictionary<Slovo, Slovo> Dic
        {
            get { return dic; }
            set { dic = value; }
        }

        public Slovnik()
        {

        }

        public void Add(Slovo k, Slovo v)
        {
            dic.Add(k,v);
        }

        public override string ToString()
        {
            string vypis = "";
            foreach (KeyValuePair<Slovo, Slovo> d in dic)
            {
                vypis += d.Key.ToString() +"- "+ d.Value.ToString()+"\n";
            }
            return vypis+"\n";
        }

    }
}
