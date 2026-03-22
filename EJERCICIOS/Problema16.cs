using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTEULER.EJERCICIOS
{
    internal class Problema16
    {
        public static BigInteger Resolver(int num_f, int potencia)
        {
            BigInteger result = 0;
            BigInteger numPotenciado = potenciacion(num_f, potencia);
            string numeroString = numPotenciado.ToString();

            foreach (char num in numeroString)
            {
                BigInteger valor = BigInteger.Parse(num.ToString());
                //int valor = num - '0'; es opcion pero hasta comprender porque se usa me abstendre de usar este metodo
                result += valor;
            }

            return result;
        }

        static BigInteger potenciacion(int num_f, int potencia)
        {
            BigInteger resultado = 1;

            for (int i = 0; i < potencia; i++)
            {
                resultado *= num_f;
            }

            return resultado;
        }
    }
}
