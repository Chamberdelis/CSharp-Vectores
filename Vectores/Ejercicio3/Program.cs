using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Guardar una cadena de caracteres, recorrerla y reemplazar una letra por otra. Luego mostrar el resultado. 

            char[] vec = new char [30];
            char letra, v1, v2;
            int indice = 0;

            Console.WriteLine("Ingrese una letra: ");
            letra = char.Parse(Console.ReadLine());

            while (letra != '.' && indice < 30)
            {
                vec[indice] = letra;

                Console.WriteLine(" Ingrese otra letra: ");
                letra = char.Parse(Console.ReadLine());
                
                indice++;

            }

            vec[indice] = '\0';

            indice = 0;

            Console.WriteLine("La frase completa es: ");
            while (vec[indice] != '\0')
            {
                Console.Write(vec[indice]);
                indice++;
                
            }

            Console.WriteLine();

            Console.WriteLine("Ingrese la letra muestra: ");
            v1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la letra sustituta: ");
            v2 = char.Parse(Console.ReadLine());

            indice = 0;

            while (vec[indice] != '\0')
            {
                if (vec[indice] == v1)
                {
                    vec[indice] = v2;
                }
                indice++;
            }

            indice = 0;

            Console.WriteLine("La frase procesada es: ");
            while (vec[indice] != '\0')
            {
                Console.Write(vec[indice]);
                indice++;
                
            }


        }
    }
}
