using System.Text.Json;

namespace FileIO_JSON_Serialization_And_Deserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //JSON Serialization
            string filepath = @"C:\Users\IET\Desktop\250845920024\CSharp\CSharpDemo\FileIO_JSON_Serialization_And_Deserialization\Files\File.json";

            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.EmpName = "Gaurav";
            emp.Address = "Pune";

            JsonSerializer.Serialize<Employee>(fs,emp);
            fs.Close();


            //JSON Deserialization
            FileStream fs1 = new FileStream(filepath, FileMode.Open, FileAccess.Read);

            Employee emp1 = JsonSerializer.Deserialize<Employee>(fs1);
            fs.Close();

            Console.WriteLine($"Id = {emp.EmpId}, Name = {emp.EmpName}, Address= {emp.Address}");






        }
    }

    public class Employee
    {
        private int _EmpId;
        private string _EmpName;
        private string _Address;


        public int EmpId
        {
            get { return _EmpId; }
            set { _EmpId = value; }
        }

        public string EmpName
        {
            get { return _EmpName; }
            set { _EmpName = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

    }

}
