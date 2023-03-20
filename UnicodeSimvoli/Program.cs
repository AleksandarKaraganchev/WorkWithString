using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeSimvoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи символен низ: ");
            string string1 = Console.ReadLine();
            foreach (char item in string1)
            {
                Console.Write($"\\u{(int)item:X4} " );
            }
            Console.WriteLine();
        }
    }
}
