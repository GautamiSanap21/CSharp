namespace SealedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdvanceMath obj = new AdvanceMath();
            int res = obj.Mult(5, 10);
            Console.WriteLine("Multiplication is {0}",res);

            MyMath obj2 = new MyMath();
            int result = obj2.Mult(5, 10);
            Console.WriteLine("Multiplication is {0}",result);
        }
    }

    public sealed class CMath
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
        public int Sub(int x,int y)
        {
            return x - y;
        }
    }

    public class AdvanceMath 
    {
        public virtual int Mult(int x, int y)
        {
            return x * y;
        }
    }

    public class MyMath : AdvanceMath
    {
        public override int Mult(int x, int y)
        {
            return x * y * 10;
        }
        public virtual int Div(int x, int y)
        {
            return x / y;
        }
    }

    public class MyMath2 : MyMath
    {
        public override int Div(int x, int y)
        {
            return x / y + 10;
        }
    }
}
