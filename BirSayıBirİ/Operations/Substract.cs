using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirSayıBirİ.Operations
{
    public class Substract : Operation
    {
        public int eval(int x, int y)
        {
            if (x < y)
            {
                return y - x;
            }
            else
            {
                return x - y;
            }
        }

        public string symbol()
        {
            return "-";
        }
    }
}
