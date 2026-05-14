

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Ordenar
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] cargados = null;
            int [] cargados2 = null;
            int d;
            Console.WriteLine("Ingresa la cantidad de numeros para el array");
            if (int.TryParse(Console.ReadLine(), out int c))
            {
                cargados = new int[c];
            }

            Console.WriteLine("Ingrese los numeros");
            for (int i = 0; i < c; i++)
            {
                Console.Write($"Numero ({i + 1}): ");
                if (int.TryParse(Console.ReadLine(), out int v))
                {
                    cargados[i] = v;
                }
                else
                {
                    Console.WriteLine("La entrada no es valida, se pondra 0");
                    cargados[i] = 0;
                }

            }

            for (int i = 0; i < c; i++) {

                for (int j = 1; j < i; j++)
                {
                    if (cargados[j] < cargados[i])
                    {
                        d = cargados[i];
                        cargados[i] = cargados[j];
                        cargados[j] = d;
                        cargados2[] = new int[d]; 
                    }

                }
            }

        }
    }
}