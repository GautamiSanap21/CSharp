namespace MultiCastDelegate
{

    public delegate void mydelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Demo demo = new Demo();
            mydelegate d = new mydelegate(demo.m1);
            d += demo.m2;
            d += demo.m3;
            d += demo.m4;
            d += demo.m5;
            d();


        }
    }

    class Demo
    {
        public void m1()
        {
            Console.WriteLine("in m1 method");
        }
        public void m2()
        {
            Console.WriteLine("in m2 method");
        }
        public void m3()
        {
            Console.WriteLine("in m3 method");
        }
        public void m4()
        {
            Console.WriteLine("in m4 method");
        }
        public void m5()
        {
            Console.WriteLine("in m5 method");
        }
    }

}
