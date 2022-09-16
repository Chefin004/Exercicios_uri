using System;
using System.Globalization;
namespace uri_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int quociente, resto, nota, moeda;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resto = (int)(N * 100 + 0.5);

            Console.WriteLine("NOTAS:");

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + "00");
            resto = resto % (nota * 100);


            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + "00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + "00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + "00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + "00");
            resto = resto % (nota * 100);

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + "00");
            resto = resto % (nota * 100);


            Console.WriteLine("MOEDAS:");

            moeda = 2;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + nota + "0.02");
            resto = resto % moeda;


            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + nota + "1.00");
            resto = resto % moeda;


            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + nota + "0.50");
            resto = resto % moeda;


            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + nota + "0.25");
            resto = resto % moeda;


            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + nota + "0.10");
            resto = resto % moeda;


            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + nota + "0.05");
            resto = resto % moeda;


            moeda = 1;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + nota + "0.01");
            resto = resto % moeda;
























        }
    }
}
