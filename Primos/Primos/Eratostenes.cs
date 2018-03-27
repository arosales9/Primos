using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Eratostenes
    {
        public static int _max;

        public Eratostenes(int num)
        {
            _max = num;
        }

        public string Primos()
        {
            int nume=0;
            int[,] num = new int[_max, 2];
            string primos = "";

            for (int i = 2; i < _max; i++) //Rellenamos el array
            {
                num[i, 0] = i;
                num[i, 1] = 0;
            }

            for (int i = 2; i < _max; i++)
            {
                if (num[i, 1] == 0)
                {
                    primos = primos + i.ToString() + ",";
                    for (int e = 1; e < _max + 1; e++)
                    {
                        nume = num[i, 0];
                        nume = nume * e;
                        if (nume < _max)
                        {
                            num[nume, 1] = 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            primos = primos.Substring(0, primos.Length - 1);
            //Console.WriteLine("Numeros primos encontrados: {0}", primos);
            //Console.Read();
            return primos;
        }
    }
}
