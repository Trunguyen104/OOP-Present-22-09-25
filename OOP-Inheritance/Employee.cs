using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Employee
    {
        private int id;
        private string name;
        //Constructor
        public Employee(int id, string name) {
            this.id = id;
            this.name = name;
        }

        //Properties
        public int Id { 
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
