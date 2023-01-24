using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Hacer un programa que solicite 10 números enteros y los guarde en un vector.

            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            int[] num = new int[10];
            int n;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                num[i] = n;
            }

            int
                max = num[0],
                pos = 1;

            for (int x = 0; x < 10; x++)
            {
                if (num[x] >= max)
                {
                    max = num[x];
                    pos = x + 1;
                }
            }

            Console
                .WriteLine("El mayor de los numeros es: " +
                max +
                " En la posición: " +
                pos);
        }
    }
}
