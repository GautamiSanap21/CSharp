namespace OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Person
            
            Person person = new Person();
            person.first_name = "Abc";
            person.last_name = "Def";
            Console.WriteLine(person);
            #endregion

            #region Employee

            Employee employee = new Employee();
            employee.id = 1;

            Console.WriteLine(employee);
            Console.WriteLine("Name = {0} {1} id={2}",person.first_name,person.last_name,employee.id);
            #endregion
        }
    }
}
