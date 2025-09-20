using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_onlyAutoProperties_Init_OnlyProperties
{
    internal class MyClass
    {
        //Init-Only Properties
        public int x { get; init; }
        //Read-Only Auto Properties
        public int y { get; }
        public MyClass()
        {
            x = 10;
            y = 20;
        }
        public MyClass(int a, int b)
        {
            x = a;
            y = b;
        }
    }
}
