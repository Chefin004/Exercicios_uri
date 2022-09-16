using System;
using System.Globalization;
namespace uri_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOME = Console.ReadLine();
            double Sf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double NTV = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double Comissao = NTV * 0.15;
            double BONUS = Sf + Comissao;


            Console.WriteLine("TOTAL = R$ " + BONUS.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
