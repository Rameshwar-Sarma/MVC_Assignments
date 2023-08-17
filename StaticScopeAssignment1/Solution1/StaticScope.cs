using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1
{

    class StaticScope
    {
        public void method1() 
        { 
        Console.WriteLine("Value of var1 before Assignment :"+Program.var1);
        Console.WriteLine("Value of str1 before Assignment :" + Program.str1);
        Program.var1 = 26;
        Program.str1 = "in Static Scope";
        Console.WriteLine("Value of var1 after Assignment :" + Program.var1);
        Console.WriteLine("Value of str1 after Assignment :" + Program.str1);
        }
    }
}
