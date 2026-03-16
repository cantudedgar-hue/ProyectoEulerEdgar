using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTEULER.EJERCICIOS
{
    internal class Problema02
    {
        public static long Resolver(int n)
        {
            long resultado = SucecionFibonacci(n);
            
            return resultado;
        }

        static long SucecionFibonacci(long num_f)
        {
            List<long> lista_fibonacci = [2];
            long resultado = 0;
            long f0 = 1;
            long f1 = 2;
            long f2 = 0;

            for (long i = 0; i < num_f + 1; i++)
            {
                f2 = f1 + f0;
                if(!(f2 > 4000000))
                {
                    if (f2 % 2 == 0)
                    {
                        
                        lista_fibonacci.Add(f2);
                    }
                    
                    f0 = f1;
                    f1 = f2;         
                }
                else
                {
                    break;
                }
            }

            resultado = lista_fibonacci.Sum();

            return resultado;
        }
    }
}
