using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTEULER.EJERCICIOS
{
    internal class Problema03
    {
        public static long Resolver(long num_f)
        {
            int limite = 100;
            int limite_sup = 100;
            int limite_inf = 2;
            List<long> factoresPrimos = new List<long>();

            while (limite <= limite_sup)
            {
                for (long i = limite_inf; i < limite_sup; i++)
                {
                    if (!NumesrosPrimos(i)) 
                    {
                        continue;
                    }

                    while (num_f % i == 0)
                    {
                        num_f = num_f / i;
                        factoresPrimos.Add(i);
                    }
                }

                if (num_f != 1)
                {
                    limite_inf = limite_sup;
                    limite_sup += 100;
                    limite += 100;
                }
                else {
                    break;
                }
            }

            int resultado = (int)(factoresPrimos.Count > 0 ? factoresPrimos.Max() : 0);

            return resultado;

        }
        static bool NumesrosPrimos(long num_f)
        {
            if (num_f < 2) return false;
            if (num_f == 2) return true;
            if (num_f % 2 == 0) return false;

            int limite = (int)Math.Truncate(Math.Sqrt(num_f));

            for (int i = 3; i <= limite; i += 2)
            {
                if (num_f % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
