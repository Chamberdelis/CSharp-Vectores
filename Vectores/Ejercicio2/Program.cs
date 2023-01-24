using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Hacer un programa que solicite 10  números enteros y los guarde en un vector.

            //Luego recorrer ese vector para calcular el promedio.

            //Mostrar por pantalla los valores que son mayores al promedio.
            int
                n,
                acu = 0,
                prom;
            int[] vec = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escriba el numero: ");
                n = int.Parse(Console.ReadLine());

                vec[i] = n;
            }

            for (int x = 0; x < 10; x++)
            {
                acu += vec[x];
            }

            prom = acu / 10;

            for (int y = 0; y < 10; y++)
            {
                if (vec[y] > prom)
                {
                    Console
                        .WriteLine("El valor tal: " +
                        vec[y] +
                        " es mayor al promedio: " +
                        prom);
                }
            }
        }
    }
}
