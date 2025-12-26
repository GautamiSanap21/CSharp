using System.Reflection;

namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Derived d = new Derived();
            d.m1();
            d.m2();
            d.m3();
        }
    }

    public class Base
    {
        public void m1()
        {
            Console.WriteLine("In m1 method");
        }
        public void m2()
        {
            Console.WriteLine("In m2 method");
        }

        //if we use the virtual keyword then we are able to make some changes in implementation
        public virtual void m3()
        {
            Console.WriteLine("In m3 method");
        }
    }
    public class Derived : Base
    {
        //use override keyword to change in the implementation of virtual functiona
        public override void m3()
        {
            Console.WriteLine("In m3 method");
            Console.WriteLine("awrh");
        }

        //Hides the inherited method, with the same name, creating a new, separate method in the derived class with new implementation.
        public new void m2() 
        {
            Console.WriteLine("In m2 method");
            Console.WriteLine("jaghdsjk");
        }
    }
}
