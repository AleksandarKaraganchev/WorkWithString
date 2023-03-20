using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmnojavaneNaGolemiChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            string result = Multiplication(n, num);
            Console.WriteLine(result);
        }

        private static string Multiplication(string n, int num)
        {
            if (n == "0" || num == 0)
            {
                return "0";
            }
             //?
        }
    }
}
