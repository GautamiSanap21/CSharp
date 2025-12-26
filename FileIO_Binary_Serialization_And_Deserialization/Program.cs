using System.Diagnostics.Tracing;
using System.Text.Json.Serialization;

namespace FileIO_Binary_Serialization_And_Deserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.EmpName = "abc";
            emp.Address = "Pune";


            Console.WriteLine("Hello, World!");

            string filepath = @"C:\Users\IET\Desktop\250845920024\CSharp\CSharpDemo\FileIO_Binary_Serialization_And_Deserialization\Files\file.txt";

            FileStream fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);

            //BinaryFormatter bf = new BinaryFormatter();
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(emp.EmpId);
            bw.Write(emp.EmpName);
            bw.Write(emp.Address);
            bw.Close();
            fs.Close();

            FileStream fs1 = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs1);
            Employee emp1 = new Employee();
            emp1.EmpId = br.ReadInt32();
            emp1.EmpName = br.ReadString();
            //emp1.Address = br.ReadString();
            emp1.Address = null;
            Console.WriteLine($"Emp Id: {emp1.EmpId}, Emp Name: {emp1.EmpName}, Emp Adress: {emp1.Address}");


        }
    }
    [Serializable]
    class Employee
    {
        private int _EmpId;
        private string _EmpName;
        [NonSerialized]
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
    class Book
    {
        private int _BookId;
        private string _BookName;


        public int BookId
        {
            get { return _BookId; }
            set { _BookId = value; }
        }
        public string BookName
        {
            get { return _BookName; }
            set { _BookName = value; }
        }

    }
}
