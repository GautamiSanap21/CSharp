namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find Prime Numbers");
            Console.Write("Enter a number: ");
            String num2 = Console.ReadLine();//readline always returns string
            int num3 = int.Parse(num2);//int.parse will convert string to int
            bool result =  isPrime(num3);
            if (result)
            {
                Console.WriteLine(num3+" is Prime");
            }
            else
            {
                Console.WriteLine(num3+" is not Prime");
                
            }



        }

        public static bool isPrime(int num) {
            if (num == 0 || num == 1)
            {
                return false;
            }

            for (int i = 2; i <= num-1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
                    return true;
        }
    }
}
