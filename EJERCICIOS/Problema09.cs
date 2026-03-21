using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTEULER.EJERCICIOS
{
    internal class Problema09
    {
        public static void Resolver()
        {
            int suma_objetivo = 1000;
            for(int i = 1; i < suma_objetivo / 3; i++)
            {
                for (int j = 1; j < suma_objetivo / 2; j++)
                {
                    int c = suma_objetivo - i - j;
                    if(i*i + j*j == c*c)
                    {
                        Console.WriteLine($"a={i}, b={j}, c={c}");
                        Console.WriteLine($"El producto abc es: {i * j * c}");

                    }
                }
            }
        }
    }
}
