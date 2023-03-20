using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Палиндром- една или няколко думи или числа, които се четат по един и същ начин от ляво надясно и от дясно наляво.
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Въведи символен низ и ще ти кажа дали е палиндром: ");
            string string1 = Console.ReadLine();
            bool palindrome = IfPalindrome(string1);
            Console.WriteLine("----------------------------------------------------");
            if (palindrome == true)
            {
                Console.WriteLine($"{palindrome} думата е палиндром");
            }
            else
            {
                Console.WriteLine($"{palindrome} думата не е палиндром!!!");
            }
            Console.WriteLine("----------------------------------------------------");

        }
        private static bool IfPalindrome(string string1)
        {
            for (int i = 0; i < string1.Length / 2; i++)
            {
                if (string1[i] != string1[string1.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
