namespace DelegateDemo
{

    //delegates
    public delegate void MyDelegate();


    //delegates with return type
    public delegate int MyDelegate2(int p, int q);

    internal class Program
    {
        static void Main(string[] args)
        {
            greet g = new greet();
            MyDelegate del = new MyDelegate(g.sayHello);
            del.Invoke();
            del();

            int num1 = 10;
            int num2 = 10;

            Calc c = new Calc();
            MyDelegate2 del2 = new MyDelegate2(c.add);
            Console.WriteLine(del2(num1, num2));

        }
    }

    class greet
    {
        public void sayHello()
        {
            Console.WriteLine("Hello!!!");
        }
    }


    class Calc
    {
        public int add(int a , int b)
        {
            return a + b;
        }
    }

}
