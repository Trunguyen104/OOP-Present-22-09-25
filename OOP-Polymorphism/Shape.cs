using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Performing base class Drawing tasks");
        }

        public void Print()
        {
            Console.WriteLine("Performing base class Print tasks");
        }

        public abstract void Display();
    }
}
