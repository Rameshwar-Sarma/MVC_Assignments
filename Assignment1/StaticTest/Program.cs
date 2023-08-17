using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution1;

namespace StaticTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution1.Program.var1);
            Console.WriteLine(Solution1.Program.str1);
            Solution1.Program.var1 = 95;
            Solution1.Program.str1 = "I Love Chess";
            Console.ReadLine();
        }
    }
}
