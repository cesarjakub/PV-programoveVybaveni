using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputZKlavesnice
{
    public class MatematickeUpravy
    {

        private int a;
        private int b;

        public MatematickeUpravy(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Add()
        {
            return a + b;
        }

        public int Odecti()
        {
            return a - b;
        }

        public int mul()
        {
            return a * b;
        }

        public int div()
        {
            if (b == 0)
            {
                return b / a;
            }
            if (a == 0 && b == 0)
            {
                return 0;
            }
            return a / b;
        }

    }
}
