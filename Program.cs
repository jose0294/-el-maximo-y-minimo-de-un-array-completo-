using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = LLenarArray();
             ImprimirArray(A);
            Console.ReadLine();
        }
        static int[] LLenarArray()
        {
            Console.WriteLine( "ingresar la cantidad de numeros a ingresar ");
            int x = int.Parse(Console.ReadLine());
            int[] A = new int[x];
            for (int i = 1; i <= A.Length ; i++)
            {
                Console.WriteLine($"ingresar numero {i}");
                A[i - 1] = int.Parse(Console.ReadLine());
            }
            return A;

        }
        static void ImprimirArray(int[] A)

        {
            Console.WriteLine("los elentos igresados son :");
            foreach (var item in A)
            {
               
                Console.WriteLine($"*{item}");
            }
            int mayor = A[0],menor=A[0];
            for (int i = 0; i < A.Length; i++)
            
            {
                if (A[i]>mayor)
                {
                    mayor = A[i];
                }
                if (A[i]<menor)
                {
                    menor = A[i];
                }

            }
            Console.WriteLine($"el mayoor del array es:{mayor}---- el menoor es {menor}");

        }
    }
}
