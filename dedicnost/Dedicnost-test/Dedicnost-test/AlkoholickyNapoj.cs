using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_test
{
    public class AlkoholickyNapoj : Napoj
    {
        private int procAlk;

        public AlkoholickyNapoj(int procAlk, int cena, string nazev) : base(cena, nazev)
        {
            this.procAlk = procAlk;
        }

        public int ProcAlk 
        { 
            get { return procAlk; }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Nejedna se o alkohol");
                }
                this.procAlk = value;
            }
        }

        public override string? ToString()
        {
            return base.ToString()+", Alk: "+procAlk+"%";
        }
    }
}
