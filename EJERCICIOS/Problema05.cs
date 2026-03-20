using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTEULER.EJERCICIOS
{
    internal class Problema05
    {
        public static long Resolver()
        {
            long limite_inf = 1;
            long limite_sup = 100;

            while (true)
            {
                for (long i = limite_inf; i <= limite_sup; i++)
                {
                    bool esValido = true;

                    for (long n = 1; n <= 21; n++)
                    {
                        if (i % n != 0)
                        {
                            esValido = false;
                            break;
                        }
                    }

                    if (esValido)
                    {
                        return i;
                    }
                }
                limite_inf = limite_sup + 1;
                limite_sup *= 2;
            }
        }
    }
}
