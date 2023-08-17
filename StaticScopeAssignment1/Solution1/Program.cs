using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Solution1
{
    public class Program
    {
        public static int var1 = 10;
        public static String str1 = "C# .Net" ;
        static void Main(string[] args)
        {
            var1 = 25;
            str1 = "Welcome";
            Console.WriteLine("var1 before calling scope method = " + var1);
            Console.WriteLine("str1 before calling scope method = " + str1);
            StaticScope scope = new StaticScope();
            scope.method1();
            Console.WriteLine("var1 after calling scope method = " + var1);
            Console.WriteLine("str1 after calling scope method = " + str1);
            Console.ReadLine();
        }

    }
}

