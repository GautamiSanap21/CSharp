using CSharpFeatures.File1;

namespace CSharpFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cmath = new CMath();
            //Console.WriteLine($"Sub result = {cmath.Sub(20, 10)}");
            Console.WriteLine($"Add result = {cmath.Add(5, 10)}");
        }
    }
}
