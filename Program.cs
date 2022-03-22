using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = Int32.MinValue;
            int maximo = Int32.MaxValue;
            int acumulador= 0;
            int contador = 0;
            float promedio;
            bool flagMaximo= true;
            bool flagMinimo= true;

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                acumulador += numero;
                contador++;

                if (flagMaximo == true || numero > maximo) 
                {
                    maximo = numero;
                    flagMaximo = false;
                }
                if (flagMinimo == true || numero < minimo) 
                {
                    minimo = numero;
                    flagMinimo = false;
                }

            }

            promedio = (float)acumulador / contador;

            Console.WriteLine($"El minimo es: {minimo}, el maximo es: {maximo} y el promedio es: {promedio}");
        }
    }
}
