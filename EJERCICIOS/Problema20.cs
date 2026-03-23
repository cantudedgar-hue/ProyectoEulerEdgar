using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTEULER.EJERCICIOS
{
    internal class Problema20
    {
        public static BigInteger Resolver(int num_f)
        {
            BigInteger result = 0;
            BigInteger numFactorizado = Factorial(num_f);
            string numFactorizado_string = numFactorizado.ToString();

            foreach (char f in numFactorizado_string)
            {
                BigInteger valor = BigInteger.Parse(f.ToString());
                result += valor;
            }

            return result;
        }

        static BigInteger Factorial(int num_f)
        {
            BigInteger result = 1;
            for (int i = num_f; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
