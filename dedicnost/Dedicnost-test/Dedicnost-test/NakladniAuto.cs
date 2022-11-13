using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_test
{
    public class NakladniAuto: Auto
    {
        private int hmotnost;

        public NakladniAuto(int hmotnost, string spz, double rychlost) : base(spz, rychlost)
        {
            this.hmotnost = hmotnost;
        }

        public int Hmotnost
        {
            get { return hmotnost; }
            set { this.hmotnost = value; }
        }

        public override string? ToString()
        {
            return base.ToString()+", hmotnost, kterou veze: "+hmotnost+"tun";
        }
    }
}
