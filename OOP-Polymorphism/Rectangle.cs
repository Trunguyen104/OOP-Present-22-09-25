using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
        public new void Print()
        {
            Console.WriteLine("Print a Rectangle");
        }
        public override void Display()
        {
            Console.WriteLine("Display Rectangle");
        }
    }
}
