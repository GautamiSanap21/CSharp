using CMathLibrary;

namespace CMathClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CMath c = new CMath();
            c.Add(10, 10);
            
        }
    }

    class DemoOnMath : CMath 
    {
        
        public void wrapperMethod()
        {
            base.Mult(1,3);
            base.Square(1);
        }
    }
}