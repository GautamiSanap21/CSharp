namespace ExplicitInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo1 d1 = new Demo1();
            d1.m1();


            //for explicit
            Demo2 d2 = new Demo2();
            //d2.m1();//gives error: not accessible

            i1 i11 = new Demo2();
            i11.m1();// Works only through the interface
            i2 i22 = new Demo2();
            i22.m1();// Works only through the interface

        }
    }

    //when we work with implicit implementation it is mandatory to set all inherited methods to public
    public class Demo1 : i1, i2
    {
        public void m1()//Implicit Implementation
        {
            Console.WriteLine("m1 method of interface");
        }

       
    }
    public class Demo2 : i1, i2
    {
        void i1.m1()//Explicit Implementation
        {
            Console.WriteLine("m1 method of interface 1");
        }

        void i2.m1()//Explicit Implementation
        {
            Console.WriteLine("m1 method of interface 2");
        }
    }

    public interface i1
    {
        public void m1();

    }
    public interface i2
    {
        public void m1();

    }

}
