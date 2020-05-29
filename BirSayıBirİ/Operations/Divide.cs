using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirSayıBirİ.Operations
{
    public class Divide : Operation
    {
        public int eval(int x, int y)
        {
            if (x < y)
            {
                int t = x;
                x = y;
                y = t;
            }
            if (x % y == 0)
            {
                return x / y;
            }
            else
            {
                return 0;
            }
        }

        public string symbol()
        {
            return "/";
        }
    }
}
