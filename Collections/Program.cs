using System.Collections;
using System.Xml.Linq;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Collections
            //2 - Types(Generic and Non-Generic)

            //Non_Generic --> These collections store elements as a objects, so they can hold any type of data. This is not type safe

            //Common non-generic collections
            //    ArrayList
            //    Hashtable
            //    Queue
            //    Stack

            //Generic --> These collections store elements with specific type only, thats why it is type safe

            //Common generic collections
            //List<T>
            //Dictionary<TKey, TValue>
            //Queue<T>
            //Stack<T>
            //HashSet<T>


            #region Non-Generic Collections
            //ArrayList
            ArrayList alist = new ArrayList();
            alist.Add(10);
            alist.Add(87.9872);
            alist.Add('A');
            alist.Add("ajks");
            Sample s = new Sample();
            s.SampleId = 1001;
            alist.Add(s);




            //for (int i = 0; i < alist.Count; i++)
            //{
            //    Object element = alist[i];
            //    if (element is int)
            //    {
            //        Console.WriteLine(Convert.ToInt32(element));
            //    }
            //    if (element is double)
            //    {
            //        Console.WriteLine(Convert.ToDouble(element));
            //    }

            //    if (element is char)
            //    {
            //        Console.WriteLine(Convert.ToChar(element));
            //    }

            //    if (element is string)
            //    {
            //        Console.WriteLine(Convert.ToString(element));
            //    }

            //    if (element is Sample)
            //    {
            //        Sample s1 = element as Sample;
            //        Console.WriteLine(s1.SampleId);
            //    }
            //}

            //instead of writing for loop and multiple if conditions write the forEach loop 

            foreach (Object elements in alist)
            {
                if (elements is Sample)
                {
                    Sample sample1 = elements as Sample;
                    Console.WriteLine(sample1.SampleId);
                }
                else
                {
                    Console.WriteLine(elements);

                }
            }



            #endregion

            #region Generic Collections

            #region List

            //List
            //List of Integer
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (int elements in list)
            {
                Console.WriteLine(elements);
            }



            //List of Sample objects
            List<Sample> slist = new List<Sample>();

            Sample s1 = new Sample();
            s1.SampleId = 100;
            Sample s2 = new Sample();
            s2.SampleId = 101;
            Sample s3 = new Sample();
            s3.SampleId = 102;
            Sample s4 = new Sample();
            s4.SampleId = 103;

            slist.Add(s1);
            slist.Add(s2);
            slist.Add(s3);
            slist.Add(s4);

            foreach (Sample elements in slist)
            {
                Console.WriteLine(elements.SampleId);
            }


            #endregion

            #region Dictionary

            Dictionary<int,String> dict = new Dictionary<int,String>();
            dict.Add(1, "kljh");
            dict.Add(2, "sef");
            dict.Add(3, "wrgh");
            dict.Add(4, "era");
            dict.Add(5, "eqrt");
            


            Console.WriteLine(dict[1]);//read the value of key 1

            //read all keys only
            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }

            //read all values only
            foreach (String item in dict.Values)
            {
                Console.WriteLine(item);
            }

            //read all key-value of dictionary
            foreach (KeyValuePair<int, String> item in dict)
            {
                Console.WriteLine(item.Key +" "+item.Value);
            }



            #endregion

            #region Stack

            Stack<int> sint = new Stack<int>();
            sint.Push(10);
            sint.Push(20);
            sint.Push(100);
            sint.Push(1);
            sint.Push(867);
            sint.Push(5);
            sint.Pop();

            foreach (int elements in sint)
            {
                Console.WriteLine(elements);
            }

            #endregion

            #region Queue

            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(100);
            q.Enqueue(1);
            q.Enqueue(19);
            q.Dequeue();

            foreach (int element in q)
            {
                Console.WriteLine(element);
            }


            #endregion

            #endregion



        }
    }

    class Sample
    {
        private int _sampleId;

        public int SampleId
        {
            get { return _sampleId; }
            set { _sampleId = value; }
        }

    }

    class Employee
    {
        private int _EmpId;
        private string _EName;
        private string _EAddress;

        public int EmpId
        {
            get { return _EmpId; }
            set { _EmpId = value; }
        }
        public string EName
        {
            get { return _EName; }
            set { _EName = value; }
        }
        public string EAddress
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }

    }
}
