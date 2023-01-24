using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Una empresa comercializa 15 tipos de artículos y por cada venta
            //realizada genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida
            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.
            int
                na,
                cv,
                art,
                masV;

            int[] vecArt = new int[15];

            for (int i = 0; i < 15; i++)
            {
                vecArt[i] = 0;
            }

            Console.WriteLine("Ingrese el nro de articulo ( 1 al 15): ");
            na = int.Parse(Console.ReadLine());
            Console
                .WriteLine("Ingrese la cantidad vendida de dicho articulo: ");
            cv = int.Parse(Console.ReadLine());

            while (na != 0)
            {
                vecArt[na - 1] += cv;

                Console.WriteLine("Ingrese el nro de articulo ( 1 al 15): ");
                na = int.Parse(Console.ReadLine());
                Console
                    .WriteLine("Ingrese la cantidad vendida de dicho articulo: ");
                cv = int.Parse(Console.ReadLine());
            }

            art = 1;
            masV = vecArt[0];

            for (int x = 0; x < 15; x++)
            {
                if (vecArt[x] >= masV)
                {
                    masV = vecArt[x];
                    art = x + 1;
                }
            }

            Console
                .WriteLine("El articulo que mas se vendió es: " +
                art +
                " cuyas ventas fueron de: " +
                masV);
            Console.WriteLine();

            Console.WriteLine("El nro de articulo que no registro ventas es: ");

            Console.WriteLine();

            for (int y = 0; y < 15; y++)
            {
                if (vecArt[y] == 0)
                {
                    Console.Write(" " + (y + 1) + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Console
                .WriteLine("El articulo 10 registro una cantidad de: " +
                vecArt[9] +
                " ventas.");
        }
    }
}
