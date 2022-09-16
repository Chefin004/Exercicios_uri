using System;
using System.Globalization;
namespace uri_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int autonomia = 12;
            float horaspercorridas, velocidademedia, gastocombustivel;

            horaspercorridas = float.Parse(Console.ReadLine());
            velocidademedia = float.Parse(Console.ReadLine());

            gastocombustivel = (velocidademedia / autonomia) * horaspercorridas;
            Console.WriteLine(gastocombustivel.ToString("F3", CultureInfo.InvariantCulture));




        }
    }
}
