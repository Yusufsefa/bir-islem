using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirSayıBirİ
{
    public class RndNumber
    {

        private static RndNumber instance = null;
        private Random generator;
        private int hedefSayi;

        private RndNumber()
        {
            generator = new Random();
        }

        public static RndNumber getInstance()
        {
            if (instance == null)
            {
                instance = new RndNumber();
            }
            return instance;
        }
        public int getHedefSayi()
        {
            hedefSayi = this.generator.Next(100, 1000);
            return hedefSayi;
        }


        public int[] getRastgeleSayilar()
        {
            int[] result = new int[6];

            for (int i = 0; i < 6; i++)
            {
                result[i] = this.generator.Next(1, 10);

                if (i == 5)
                {
                    while (true)
                    {
                        int temp = this.generator.Next(10, 100);

                        if (temp % 10 == 0)
                        {
                            result[i] = temp;
                            break;
                        }
                    }
                }

                for (int j = 0; j < i; j++)
                {
                    if (result[j] == result[i])
                    {
                        i--;
                        break;
                    }
                }

            }
            return result;
        }

    }
}   

