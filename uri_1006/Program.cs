using System;
using System.Globalization;
namespace uri_1006
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            

           double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notadaprova1 = A * 2;
            double notadaprova2 = B * 3;
            double notadaprova3 = C * 5;
            double media = (notadaprova1 + notadaprova2 + notadaprova3) / 10;
            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));






        }
    }
}
