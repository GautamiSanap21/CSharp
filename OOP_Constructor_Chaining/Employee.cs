using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Constructor_Chaining
{
    internal class Employee
    {
        
        public Employee(String name)  
        {
            Console.WriteLine("Name of employee is "+name);
        }

        //constructor chaining - within the class
        public Employee(String name, int age) : this(name) 
        { 
            Console.WriteLine("Name of employee is "+name+" and age is: "+age);
        
        }
    }
}
