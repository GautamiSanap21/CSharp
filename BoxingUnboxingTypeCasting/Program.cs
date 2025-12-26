namespace BoxingUnboxingTypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing Unboxing And TypeCasting

            //Boxing - Convert value type(primitive type) to reference type(non primitive type)
            //UnBoxing - Convert reference type(non primitive type) to value type(primitive type)
            //Type Casting - Converting value type to value and reference type to reference

            int x = 100;//Value type
            String str = "Hello";//reference type

            #region Boxing

            Object obj = new Object();//reference type
            obj = x;//Boxing(implicit)
            String str1 = Convert.ToString(x);//Boxing(explicit)
            Console.WriteLine(str1);
            Console.WriteLine(obj);

            //Console.WriteLine(str1.GetType());
            //Console.WriteLine(obj.GetType());
            //Console.WriteLine(x.GetType());
            //Console.WriteLine(x.GetType());

            #endregion

            #region UnBoxing

            int a = Convert.ToInt32(str1);//UnBoxing(explicit)
            int b = Convert.ToInt32(obj);//UnBoxing(explicit)
            Console.WriteLine(a);
            Console.WriteLine(b);

            #endregion

            #region TypeCasting

            double d = 3.645297;
            int c = Convert.ToInt32(d);//explicit type casting
            Console.WriteLine(c);

            int num1 = 34;
            double d1 = num1;//implicit type casting
            Console.WriteLine(d1);

            #endregion


            #endregion





        }
    }
}
