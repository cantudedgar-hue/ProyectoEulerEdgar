using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTEULER.EJERCICIOS
{
    internal class Problema04
    {
        public static int Resolver()
        {
            int resultado = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int producto = i * j;
                    if (producto.ToString() == new string(producto.ToString().Reverse().ToArray()))
                    {
                        if (resultado < producto)
                        {
                            resultado = producto;
                        }    
                    }
                }
            }
            return resultado;
        }
    }
}
