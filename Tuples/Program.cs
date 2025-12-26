using System.Security.Cryptography.X509Certificates;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //value tuple
            var Student = (1, "gaurav", 15);//out of 40
            Console.WriteLine(Student.Item1);
            Console.WriteLine(Student.Item2);
            Console.WriteLine(Student.Item3);

            //Name tuple
            var Student1 = (ID:1, Name:"gaurav", Marks:15);//out of 40
            Console.WriteLine(Student1.ID);
            Console.WriteLine(Student1.Name);
            Console.WriteLine(Student1.Marks);

            var result = Display();
            Console.WriteLine(result);

            var result2 = DisplayData(23,"kasjg");
            Console.WriteLine(result2);



            static (int num,string data) Display() {

                int num1 = 10;
                string data = "something";
                return (num1, data);//returns multiple values from method
            }

            static (int num,string data) DisplayData(int num, string str) {

                int num1 = num;
                string data = str;
                return (num1, data);//returns multiple values from method
            }
        }
    }
}
