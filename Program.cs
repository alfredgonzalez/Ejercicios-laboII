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

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                acumulador += numero;
                contador++;

                if (numero > maximo) 
                {
                    maximo = numero;
                }
                if (numero < minimo) 
                {
                    minimo = numero;
                }

            }

            promedio = (float)acumulador / contador;

            Console.WriteLine($"El minimo es: {minimo}, el maximo es: {maximo} y el promedio es: {promedio}");
        }
    }
}
