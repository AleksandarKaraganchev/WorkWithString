using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreobrazuvaneOt10DoNBs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Въведи броина система и число, разделени със (space): ");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int Base = numbers[0];
            int number = numbers[1];
            string result= "";
            while (number > 0)
            {
                int n = 0;
                n = number % Base;
                result = n.ToString() + result; //ToString -преобръща друг тип в низов тип
                number = number / Base;
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"Резултата в {Base} броина система е: {result}");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
