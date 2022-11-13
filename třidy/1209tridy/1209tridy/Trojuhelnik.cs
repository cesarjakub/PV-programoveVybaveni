using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1209tridy
{
    internal class Trojuhelnik
    {
        private int A;
        private int B;
        private int C;

        public Trojuhelnik(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool pravostTroj()
        {
            if(A + B > C || B + C > A || A + C > B)
            {
                return true;
            }
            return false;
        }

        public bool rovnoramenny()
        {
            if(A == B || B == C || A==C) { return true; }   
            return false; 
        }

        public bool rovnostranny()
        {
            if(A == B && A == C && C == B) { return true; }
            return false;
        }

        public bool pravouhly()
        {
            if(A * A + B * B == C * C || B * B + C * C == A * A || A * A + C * C == B * B) { return true; }
            return false;
        }

    }
}
