using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarkulakFinal
{
    public class DiceRoll
    {
        int hozeni;
        public DiceRoll()
        {
        }

        public int hodKostkou()
        {
            Random random = new Random();
            hozeni = random.Next(1, 12);
            return hozeni;
        }
    }
}
