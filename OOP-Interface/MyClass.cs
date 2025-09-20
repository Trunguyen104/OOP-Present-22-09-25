using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    internal class MyClass : IFirst, ISecond
    {
        public void Display()
        {
            Console.WriteLine("Display method");
        }
        //Explicitly Implementing Interface
        void IFirst.Print()
        {
            Console.WriteLine("IFirst's Print method");
        }
        //Explicitly Implementing Interface
        void ISecond.Print()
        {
            Console.WriteLine("ISecond's Print method");
        }
    }
}
