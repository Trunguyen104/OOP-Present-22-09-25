using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation
{
    internal class Customer
    {
        private int Id;
        //Full properties
        public int CustomerID
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        // <=> java
        //public int GetId()
        //{
        //    return Id;
        //}
        //public void SetId(int value)
        //{
        //    Id = value;
        //}

        //Automatic properties
        public string CustomerName { get; set; } = "New customer";
        public void Print()
        {
            Console.WriteLine($"ID:{CustomerID}, Name:{CustomerName}");

        }
    }
}
