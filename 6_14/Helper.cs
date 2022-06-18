using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Helper
    {
        public static void Print(object text, ConsoleColor color = ConsoleColor.Black)
        {
           Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }public static void PrintLine(object text, ConsoleColor color = ConsoleColor.Black)
        {
           Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
