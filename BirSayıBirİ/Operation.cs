using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirSayıBirİ
{
    public interface Operation
    {
        int eval(int x, int y);
        string symbol();
    }
}
