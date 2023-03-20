using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreobrazuvaneOtNDo10Bs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Въведи бройна система и число, което да се преобразува в 10-ична бс: ");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int Base = numbers[0];
            string string1 = numbers[1].ToString(); //ToString -преобръща друг тип в низов тип
            int result = 0;
            for (int i = 0; i < string1.Length; i++)
            {
                int n = string1[i] - '0';
                result = result * Base + n;
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"Числото в 10-ична бройна система е {result}");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
