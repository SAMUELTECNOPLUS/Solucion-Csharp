using System;
using System.Data.Common;

namespace algunos20.unidos
{
    public class Arreglo1
    {
        enum Recibidos { S , N , s , n}
        private Recibidos opcion; 
        public int l { get; private set; }
        public int x { get; private set; }
        private int[] arr1;
        private int[] arr2;
        

        public Arreglo1(int longitudA, int longitudB)
        {
       
            this.l = longitudA;
            this.x = longitudB;
            this.arr1 = new int[longitudA];
            this.arr2 = new int[longitudB];
        }

        public void recibir()
        {
            Console.WriteLine($"\n--- Ingrese los números para el primer array (Capacidad: {l}) ---");
            for (int i = 0; i < l; i++)
            {
                Console.Write($"Número ({i + 1}): ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    arr1[i] = valor;
                }
                else
                { 
                    Console.WriteLine("Entrada no válida, se guardará 0.");
                    arr1[i] = 0;
                }
            }

            Console.WriteLine($"\n--- Ingrese los números para el segundo array (Capacidad: {x}) ---");
            for (int i = 0; i < x; i++)
            {
                Console.Write($"Número ({i + 1}): ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    arr2[i] = valor;
                }
                else
                {
                    Console.WriteLine("Entrada no válida, se guardará 0.");
                    arr2[i] = 0;
                }
            }

            Console.WriteLine("\nCarga finalizada con éxito.");
            Console.WriteLine("Desea Mostrar salida(S/N)");
            string cargados = Console.ReadLine()?.ToUpper() ?? "N";
            if(Enum.TryParse(cargados, out Recibidos resultados))
            {
                this.opcion = resultados;
                Console.WriteLine($"Salida de Datos....");

            } else
            {
                this.opcion = Recibidos.N;
                Console.WriteLine("Entrada no encontrada");
            }
        }
        public void mostrar()
        {
            if (opcion == Recibidos.S | opcion == Recibidos.s)
            {
                Console.WriteLine("\n========== REPORTE DE ARREGLOS ==========");

              
                Console.WriteLine("\n--- Salida del primer Array ---");
                for (int i = 0; i < l; i++)
                {
                    Console.WriteLine($" --> Posición ({i}): {arr1[i]}");
                }

              
                Console.WriteLine("\n--- Salida del segundo Array ---");
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($" --> Posición ({i}): {arr2[i]}");
                }

                Console.WriteLine("\n==========================================");
            }
            else
            {
                Console.WriteLine("\nOperación cancelada: No se mostraron los datos.");
            }
        }


    }
}