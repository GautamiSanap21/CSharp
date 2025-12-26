using System.Xml.Serialization;

namespace FileIO_XML_Serialization_And_Deserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string filepath = @"C:\Users\IET\Desktop\250845920024\CSharp\CSharpDemo\FileIO_XML_Serialization_And_Deserialization\Files\File.xml";

            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.EmpName = "Gaurav";
            emp.Address = "Pune";

            XmlSerializer xr = new XmlSerializer(typeof(Employee));
            xr.Serialize(fs, emp);
            fs.Close();


            FileStream fs1 = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            XmlSerializer xr1 = new XmlSerializer(typeof(Employee));

            Employee emp1 = xr1.Deserialize(fs1) as Employee;
            Console.WriteLine($"EmpId: {emp1.EmpId} EmpName: {emp1.EmpName} EMP Address: {emp1.Address}");
            fs.Close();



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
