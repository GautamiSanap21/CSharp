using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add(2, 3);
            add(3, 4,5);
        }
            public static void add(int a, int b) 
            {
            Console.WriteLine(a+b);
            }

            public static void add(int a, int b,int c) 
            {
            Console.WriteLine(a+b+c);
            }
    }
}
