using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Constructor_Chaining
{
   
    //Definition
    //Constructor chaining - one constructor call the another constructor within the same class or constructor of parent class

    internal class Base //Main class
    {
        public Base(int num)
        {
            Console.WriteLine("You passed number = " + num);
        }
    }
   
    //constructor chaining - using base and derived class
    internal class Derived : Base //Derived class
    {
        public Derived(int num) : base(num)
        {
            
        }
    }


}
