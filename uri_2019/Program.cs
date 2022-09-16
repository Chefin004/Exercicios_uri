using System;

namespace uri_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, horas, minutos, segundos, resto;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;


            minutos = N / 60;
            segundos = N % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
          


        }
    }
}
