namespace GenericDelegate
{
    public delegate void myDelegate();

    //public delegate void myDelegate2(string str);//instead of using this
    public delegate void myDelegate2<T>(T par1);//use this

    public delegate void myDelegate3<T1, T2>(T1 par1, T2 par2);
    public delegate void mydelegate4<T>(T a, T b);


    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            myDelegate del1 = d.SayHi;
            //you can invoke delegate by two ways
            //first way
            del1.Invoke();
            //second way
            del1();

            //myDelegate2 del2 = d.SayHello;
            myDelegate2<string> del2 = d.SayHello;
            del2("Gaurav");

            myDelegate2<int> del02 = d.Display;
            del02(23);

            myDelegate3<string, string> del3 = d.Greet;
            del3("Gaurav", "Hello");

            mydelegate4<int> del4 = d.add;
            del4(23, 2);

        }
    }

    public class Demo
    {
        public void SayHi()
        {
            Console.WriteLine("Hi there!");
        }
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
        public void Greet(string name, string msg)
        {
            Console.WriteLine($"Hey ! {name}, {msg}");
        }
        public void Display(int number)
        {
            Console.WriteLine($"Number is: {number}");
        }

        public bool CheckEven(int number)
        {
            return number % 2 == 0;
        }
        public bool CheckOdd(int number)
        {
            return number % 2 != 0;
        }


        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }

}
