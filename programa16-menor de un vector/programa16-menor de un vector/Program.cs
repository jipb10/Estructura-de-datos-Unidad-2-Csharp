using System;
using System.Diagnostics;

namespace programa16_menor_de_un_vector
{
    class Program
    {
        public class Recursividad
        {
            public int[] vector;

            public void GenerarArreglo(int n)
            {
                vector = new int[n];

                for (int i = 0; i < n; i++)
                {


                    Random aleatorio = new Random();
                    vector[i] = aleatorio.Next(1, 10);


                }


            }

            public void MostrarArreglo(int n)
            {
                Console.WriteLine("Este es su arreglo : ");

                for (int i = 0; i < n; i++)
                {




                    Console.WriteLine(vector[i]);

                }
            }

            public int Menor(int n)
            {
                int min;

                if (n == 0)
                    return vector[0];

                else
                {
                    min = Menor(n - 1);

                    if (min < vector[n - 1])
                        return min;
                    else
                        return vector[n - 1];
                }




            }
            ~Recursividad()
            {
                Console.WriteLine("Memoria de objeto recursividad liberada");
            }

        }
        static void Main(string[] args)
            {

                char opc;
                int n=0;
                int res = 0;
                Stopwatch s = new Stopwatch();
                Recursividad r = new Recursividad();
                do
                {
                    Console.Clear();
                    Console.WriteLine("a) Generar vector aleatoriamente");
                    Console.WriteLine("b) Determinar Elemento menor del vector");
                    Console.WriteLine("c) Desplegar vector y menor");
                    Console.WriteLine("d) Cerrar programa");
                    Console.Write("\nIngrese la opcion deseada : ");
                    opc = char.Parse(Console.ReadLine());
                   
                    switch (opc)
                    {
                        case 'a':
                            s.Start();
                            Console.Write("Ingrese Cuantos numeros tendra el vector : ");
                             n = int.Parse(Console.ReadLine());
                            
                            r.GenerarArreglo(n);
                            Console.WriteLine("\nVector generado!");
                            Console.ReadKey();
                            break;

                        case 'b':
                            r.Menor(n);
                            res = r.Menor(n);
                            Console.WriteLine("\nSe busco el elemento menor del vector!");
                            Console.ReadKey();

                            break;

                        case 'c':
                            
                            r.MostrarArreglo(n);

                            Console.WriteLine("\nEste es el valor menor : " + res);
                            Console.ReadKey();
                            break;

                        case 'd':
                            s.Stop();

                            Console.WriteLine($"\nTiempo: {s.Elapsed.TotalMilliseconds} ms");
                            Console.WriteLine("\nMemoria Utilizada : " + GC.GetTotalMemory(true) + " " + "bytes");
                            Console.WriteLine("\nCERRANDO PROGRAMA...");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("\nIngrese una opcion correcta");
                            Console.ReadKey();

                            break;
                    }

                } while (opc != 4);
            }
        
    }
}
