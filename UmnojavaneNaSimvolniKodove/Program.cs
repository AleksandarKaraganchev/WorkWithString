using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmnojavaneNaSimvolniKodove
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Въведи символен низ 1: ");
            string string1 = Console.ReadLine();
            Console.Write("Въведи символен низ 2: ");
            string string2 = Console.ReadLine();
            int result = Multiply(string1, string2);
            Console.WriteLine($"Изход --> ({result})");
        }
        private static int Multiply(string string1, string string2)
        {
            int result = 0;
            int minLen;
            if (string1.Length < string2.Length)
            {
                minLen = string1.Length;
            }
            else
            {
                minLen = string2.Length;
            }

            for (int i = 0; i < minLen; i++)
            {
                result += string1[i] * string2[i];
            }

            if (string1.Length != string2.Length)
            {
                string longerStr = "";

                if (string1.Length > string2.Length)
                {
                    longerStr = string1;
                }
                else
                {
                    longerStr = string2;
                }

                for (int i = minLen; i < longerStr.Length; i++)
                {
                    result += longerStr[i];
                }
            }
            return result;
        }
    }
}
