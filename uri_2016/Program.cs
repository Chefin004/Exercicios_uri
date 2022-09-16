using System;

namespace uri_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, tempo;

            int DISTANCIA = int.Parse(Console.ReadLine());
            double DISTANCIAXY = 0;
            double DISTANCIACARROX = 0;
            double DISTANCIACARROY = 0;
            int MINUTOS = 0;
            while (DISTANCIAXY < DISTANCIA)
            {
                DISTANCIACARROX += 1;
                DISTANCIACARROY += 1.5;
                DISTANCIAXY = DISTANCIACARROY - DISTANCIACARROX;
                MINUTOS += 1;
            }
            Console.WriteLine($"{MINUTOS} minutos");


        }
    }
}
