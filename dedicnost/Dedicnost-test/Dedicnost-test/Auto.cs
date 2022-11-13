using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_test
{
    public class Auto
    {
        private string spz;
        private double rychlost;

        public Auto(string spz, double rychlost)
        {
            this.spz = spz;
            this.rychlost = rychlost;
        }

        public string Spz
        {
            get { return spz; }
            set { this.spz = value; }
        }

        public double Rychlost
        {
            get { return rychlost; }
            set { this.rychlost = value; }
        }

        public override string? ToString()
        {
            return "Auto s spz: "+spz+", jede rychlosti: "+rychlost+"km/h";
        }
    }
}
