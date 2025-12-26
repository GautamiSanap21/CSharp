namespace Properties
{
    internal class Program
    {

        //Getter And Setter
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student s = new Student();
            s.sid = 1;//when we assign values it will invoke the setter
            s.sname = "abc";//when we assign values it will invoke the setter
            Console.WriteLine(s.sid);//it will invoke getter
            Console.WriteLine(s.sname);//it will invoke getter
        }
    }

    class Student
    {
        private int _sid;
        private String _sname;

        public int sid {
            //setter
            set { _sid = value; }
            //getter
            get { return _sid; }
        }
        public String sname {
            //setter
            set { _sname = value; }
            //getter
            get { return _sname; }
        }
    }

}
