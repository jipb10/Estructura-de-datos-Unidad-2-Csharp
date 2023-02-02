using System;
using System.Linq;
using System.Diagnostics;
namespace programa11_busqueda_binaria_recursiva
{
    class Program
    {
        
        public class Binario
        {
            
           
            public int[] arreglo = new int[10];
            public void GenerarArreglo()
            {
                
                
                for (int i = 0; i < arreglo.Length; i++)
                {
                    

                    Random aleatorio = new Random();
                    arreglo[i] = aleatorio.Next(10, 99);


                }

                

                for (int i = 0; i < arreglo.Length; i++)
                {
                    
                    Array.Sort(arreglo);
                    
                    
                    Console.WriteLine(arreglo[i]);
                }
            }
            public int Busqueda(int[] a,int x,int low,int high)
            {
               

                if (low > high)
                {
                    return -1;
                    
                }


                int mid = (low + high) / 2;


                if (x == a[mid])
                {
                    return mid;
                }
                else if (x < a[mid])
                {
                    return Busqueda(arreglo, x, low, mid-1);
                }
                else
                {
                   return Busqueda(arreglo,x,mid+1,high);
                }
                
            }
            ~Binario()
            {
                Console.WriteLine("Memoria de objeto binario liberada");
            }
        }
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();






            Binario b = new Binario();
                int opc;
            do
            {
                Console.Clear();
                
                
                Console.WriteLine("1.Generar y ordenar un arreglo de 10 numeros");
                Console.WriteLine("2.Buscar un elemento en particular");
                Console.WriteLine("3.Salir del programa");

                Console.Write("\nIngrese la opcion deseada : ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                    s1.Start();
                    Console.WriteLine("Este es su arreglo : ");
                    b.GenerarArreglo();
                        
                    Console.ReadKey();
                    Console.Clear();

                    
                        break;

                    case 2:
                       
                        s2.Start();
                        Console.Write("\nQue numero desea buscar? : ");
                        int n = int.Parse(Console.ReadLine());
                        
                        if (b.arreglo.Contains(n))
                        {


                            Console.WriteLine("\nEl numero " + n + " esta en la posicion " + (b.Busqueda(b.arreglo, n, 0, b.arreglo.Length - 1) + 1));
                        }
                        else
                        {
                            Console.WriteLine("\nEste numero no esta en el arreglo ");
                        }
                        
                        
                        Console.ReadKey();
                        
                        break;

                    case 3:
                        s1.Stop();
                        s2.Stop();


                        Console.WriteLine($"\nTiempo: {s1.Elapsed.TotalMilliseconds} ms");
                        Console.WriteLine($"\nTiempo: {s2.Elapsed.TotalMilliseconds} ms");



                        Console.WriteLine("\nMemoria Utilizada : " + GC.GetTotalMemory(true) + " " + "bytes");
                        Console.WriteLine("\nCerrando programa...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("\nIngrese una opcion valida");
                        Console.ReadKey();
                        
                        break;
                }
            } while (opc !=3);

        }
    }
}
