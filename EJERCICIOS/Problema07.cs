using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTEULER.EJERCICIOS
{
    internal class Problema07
    {
        public static long Resolver()
        {
            int objetivo = 10001;
            int contadorPrimosFound = 0;
            long numeroActual = 1; 

            while (contadorPrimosFound < objetivo)
            {
                numeroActual++;

                if (NumesrosPrimos(numeroActual))
                {
                    contadorPrimosFound++;
                }
            }
            return numeroActual; 
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
