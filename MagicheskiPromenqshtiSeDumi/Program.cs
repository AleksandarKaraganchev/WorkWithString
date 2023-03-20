using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicheskiPromenqshtiSeDumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Въведи 2 думи разделени със (space): ");
            string[] words = Console.ReadLine().Split(' ');
            string string1 = words[0];
            string string2 = words[1];
            bool replaceable = IfReplaceable(string1, string2);
            Console.WriteLine(replaceable);
        }
        private static bool IfReplaceable(string string1, string string2)
        {
            if (string1.Length != string2.Length && string2.Length > string1.Distinct().Count())
            {
                return false;
            }
            for (int i = 0; i < string1.Length; i++)
            {
                char char1 = string1[i];
                char char2 = string2[i];
                if (char1 != char2)
                {
                    if (string1.IndexOf(char1) != string2.IndexOf(char2))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
