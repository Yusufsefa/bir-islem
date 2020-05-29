using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirSayıBirİ.Operations
{
    public class Add : Operation
    {
        public int eval(int x, int y)
        {
            int r = x + y;
            if (r <= x || r <= y)
            {
                return 0;
            }
            else
            {
                return r;
            }
        }

        public string symbol()
        {
            return "+";
        }
    }
}
