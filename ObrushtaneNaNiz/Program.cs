using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrushtaneNaNiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Въведи символ или символи: ");
            string string1 = Console.ReadLine();
            string result = Reverse(string1);
            Console.WriteLine("--------------------Резултат------------------------------");
            Console.WriteLine(result);
            Console.WriteLine("----------------------------------------------------------");
        }
        private static string Reverse(string string1)
        {
            char[] charAction = string1.ToCharArray();
            int left = 0;
            int right = charAction.Length - 1;
            while (left < right)
            {
                char tempo = charAction[left];
                charAction[left] = charAction[right];
                charAction[right] = tempo;
                left++;
                right--;
            }
            return new string(charAction); //new string -създава нов стринг, в този случай прави return на char като стринг
        }
    }
}
