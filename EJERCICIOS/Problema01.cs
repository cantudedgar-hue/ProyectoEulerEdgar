namespace PROJECTEULER.EJERCICIOS
{
    internal class Problema01
    {
        public static int Resolver(int n)
        {
            List<int> lista = new List<int>();
            int resultado = 0;

            for (int i = 1; i < n; i++)
            {
                lista.Add(i);
            }

            List<int> multiplos = ObtenerMultiplosDeTresYCinco(lista);
            foreach (int i in multiplos)
            {
                resultado += i;
            }
            return resultado;
        }

        static List<int> ObtenerMultiplosDeTresYCinco(List<int> lista_f)
        {
            List<int> resultado = new List<int>();
            foreach (int i in lista_f)
            {

                if (i % 3 == 0)
                {
                    resultado.Add(i);
                    continue;
                }
                if (i % 5 == 0)
                {
                    resultado.Add(i);
                    continue;
                }
            }
            return resultado;
        }
    }
}
