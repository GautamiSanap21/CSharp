namespace ArrayOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array of student objects

           
            Console.WriteLine("Hello, World!");

            //Array of student object
            Student[] sarr = new Student[3];
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();

            s1.Studid = 10;
            s1.SName = "abc";
            s2.Studid = 11;
            s2.SName = "wsdr";
            s3.Studid = 12;
            s3.SName = "asef";

            sarr[0] = s1;
            sarr[1] = s2;
            sarr[2] = s3;

            for (int i = 0; i < sarr.Length; i++)
            {
                //    Console.WriteLine(sarr[i].Studid);
                //    Console.WriteLine(sarr[i].SName);
                Console.WriteLine($"Student ID: {sarr[i].Studid} Student Name: {sarr[i].SName}");
            }

            #endregion


            #region Array of Objects

            Student stud1 = new Student();//used for store only on object array
            stud1.Studid = 10;
            stud1.SName = "abc";
            Object[] ob = new Object[6];
            ob[0] = 12;
            ob[1] = 12.876;
            ob[2] = 'A';
            ob[3] = "akjdjkas";
            ob[4] = true;
            ob[5] = stud1;

            foreach (Object obj in ob)//in operator will read each item from the collection(object)
            {
                if (obj is int)//Checks whether an object is of a certain type.
                {
                    Console.WriteLine(Convert.ToInt32(obj));
                }

                if (obj is double)
                {
                    Console.WriteLine(Convert.ToDouble(obj));
                }

                if (obj is char)
                {
                    Console.WriteLine(Convert.ToChar(obj));
                }
                if (obj is string)
                {
                    Console.WriteLine(obj);
                }
                if (obj is bool)
                {
                    Console.WriteLine(Convert.ToBoolean(obj));
                }
                if (obj is Student)
                {
                    
                    Student stud = obj as Student;//as convert/cast the object into a Specific object type(student)
                    Console.WriteLine(stud.Studid);
                    Console.WriteLine(stud.SName);
                    //Console.WriteLine(stud.GetType());
                }
                
            }

            #endregion

        }
    }

    class Student
    {
        private int _Studid;
        private string _SName;

        public int Studid
        {
            get { return _Studid; }
            set { _Studid = value; }
        }
        public string SName
        {
            get { return _SName; }
            set { _SName = value; }
        }

    }

}
