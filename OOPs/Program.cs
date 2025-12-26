namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOPs

            C1 c1 = new C1();
            C2 c2 = new C2();
            c2.i2 = 21;
            c2.m3();

            c2.i1 = 378;
            c2.m1();
            

            #endregion
        }

        public class C1
        {
               public int i1;
            public void m1()
            {
                Console.WriteLine("value of i1 is "+ i1);
                Console.WriteLine("in m1 method of c1 class");
            }
            public void m2()
            {
                Console.WriteLine("in m2 method of c1 class");
            }
        }
        public class C2 : C1 
        {
            public int i2;
            public void m3()
            {
                Console.WriteLine("value of i2 is " + i2);
                Console.WriteLine("in m3 method of c2 class");
            }
            public void m4()
            {
                Console.WriteLine("in m4 method of c2 class");
            }

        }

    }
}
