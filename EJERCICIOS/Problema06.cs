using System;
using System.Collections.Generic;

namespace PROJECTEULER.EJERCICIOS
{
    internal class Problema06
    {
        public static int Resolver(int n)
        {
            List<int> lista = new List<int>();

            for (int i = 1; i < n; i++)
            {
                lista.Add(i);
            }

            int resultado = DiferenciaSumaCuadrada(lista);
            return resultado;
        }

        static int CuadradoNumero(List<int> lista_f)
        {
            int resultado = 0;

            foreach (int num_f in lista_f)
            {
                int subresultado = num_f * num_f;
                resultado += subresultado;
            }

            return resultado;
        }

        static int CuadradoSumaNumeros(List<int> lista_f)
        {
            int resultado = 0;

            foreach (int num_f in lista_f)
            {
                resultado += num_f;
            }

            return resultado * resultado;
        }

        static int DiferenciaSumaCuadrada(List<int> lista_f)
        {
            int resultado1 = CuadradoNumero(lista_f);
            int resultado2 = CuadradoSumaNumeros(lista_f);

            return resultado2 - resultado1;
        }
    }
}