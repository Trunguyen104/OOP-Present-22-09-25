using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface_2
{
    internal interface ISample
    {
        static void Print()
        {
            Console.WriteLine("Welcome to .NET");
        }
        string GetString(string s)
        {
            return "Hello" + s;
        }
    }
}
