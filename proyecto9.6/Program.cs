using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int posicion = 0;
            float promedio = 0;
            Console.Write("Que cantidad de alturas va a ingresar: ");
            int cantidad = int.Parse(Console.ReadLine());
            int[] alturas = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                posicion = i + 1;
                Console.Write("Dame la altura #" +posicion+": ");
                alturas[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < cantidad; i++)
            {
                int numero = alturas[i];
                promedio = promedio + numero;
            }

            promedio = promedio / cantidad;

            Console.WriteLine("El promedio de las alturas es "+promedio);
            Console.ReadKey();
        }
    }
}
