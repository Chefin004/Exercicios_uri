using System;
using System.Globalization;
namespace uri_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nf = int.Parse(Console.ReadLine());
            int Ht = int.Parse(Console.ReadLine());
            double RAH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double SALARIO = Ht * RAH;
            Console.WriteLine("NUMBER =" + Nf);
            Console.WriteLine("SALARY = U$" + SALARIO.ToString("F2",CultureInfo.InvariantCulture));






        }
    }
}
