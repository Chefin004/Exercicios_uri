using System;
using System.Globalization;
namespace uri_1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, r1 = 0, r2 = 0;

            string[] vet = Console.ReadLine().Split(' ');
            a = Double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = Double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = Double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r1 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            }

            Console.WriteLine("R1 = " + r1.ToString("F5",CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));


        }
    }
}
