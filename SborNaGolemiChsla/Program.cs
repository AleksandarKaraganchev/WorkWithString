using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SborNaGolemiChsla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Въведи 1 число: ");
            string string1 = Console.ReadLine();
            Console.Write("Въведи още 1 число: ");
            string string2 = Console.ReadLine();
            int maxLn = Math.Max(string1.Length, string2.Length);
            string1 = ReverseStr(string1);
            string2 = ReverseStr(string2);
            int carry = 0;
            string result = "";
            for (int i = 0; i < maxLn; i++)
            {
                int n1 = 0;
                int n2 = 0;
                if (i < string1.Length)
                {
                    n1 = string1[i] - '0';
                }
                else
                {
                    n1 = 0;
                }
                if (i < string2.Length)
                {
                    n2 = string2[i] - '0';
                }
                else
                {
                    n2 = 0;
                }
                int sum = n1 + n2 + carry;
                carry = sum / 10;
                result = result + (sum % 10).ToString();
            }
            if (carry != 0)
            {
                result = result + carry.ToString();
            }
            result = ReverseStr(result);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Полученото число е: {result}");
            Console.WriteLine("--------------------------------------------------------");
        }
        static string ReverseStr(string strings)
        {
            char[] chararr = strings.ToCharArray();
            Array.Reverse(chararr);
            return new string(chararr);
        }
    }
}

