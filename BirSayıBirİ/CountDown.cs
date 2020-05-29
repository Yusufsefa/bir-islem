using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirSayıBirİ.Operations;

namespace BirSayıBirİ
{
    public class CountDown
    {
        
        private static Operation[] OPERATIONS = { new Add(), new Substract(), new Multiply(), new Divide()};

        private List<string> solution = new List<string>();
        private int Target { get; set; }

        public Boolean findSolution(int[] t, int nb, int total)
        {
            for (int i = 0; i < nb; i++)
            {
                if (t[i] == total)
                {
                    this.Target = t[i];
                    return true;
                }

                for (int j = i + 1; j < nb; j++)
                {
                    for (int k = 0; k < OPERATIONS.Length; k++)
                    {
                        int res = OPERATIONS[k].eval(t[i], t[j]);

                        if (res != 0)
                        {
                            int savei = t[i], savej = t[j];
                            t[i] = res;
                            t[j] = t[nb - 1];

                            if (findSolution(t, nb - 1, total))
                            {
                                solution.Add(Math.Max(savei, savej) + " " + OPERATIONS[k].symbol() + " " + Math.Min(savei, savej) + " = " + res);
                                return true;
                            }
                            t[i] = savei;
                            t[j] = savej;
                        }

                    }
                }

            }
            return false;
        }

        public int PrintResult()
        {
            return Target;
        }

        public string printSolution()
        {
            string result = "";

            for (int i = solution.Count() - 1; i >= 0; i--)
            {
                result += "\n"+solution[i] + "\n";
            }

            return result;
        }

    }
}
