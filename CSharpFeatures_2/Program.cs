using System.Collections;

namespace CSharpFeatures_2
{
    public delegate bool myDelegate(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            #region Normal function call for check method
            //var result = check(num);
            //if (result)
            //{
            //    Console.WriteLine($"Number {num} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {num} is not greater than 10");   
            //} 
            #endregion

            #region function call for check method using delegates

            //myDelegate del1 = new myDelegate(check);
            //var result = del1(num);
            //if (result)
            //{
            //    Console.WriteLine($"Number {num} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {num} is not greater than 10");
            //}

            #endregion

            #region Annonymous methods using delegates

            //way 1
            //myDelegate del2 = new myDelegate(delegate (int num)
            //{
            //    return num > 10;
            //});



            //way 2
            //myDelegate del2 = delegate (int num)
            //{
            //    return num > 10;
            //};

            //var result = del2(num);
            //if (result)
            //{
            //    Console.WriteLine($"Number {num} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {num} is not greater than 10");
            //}

            #endregion

            #region Goes to operator(=>)
            ////way 1
            //myDelegate del3 = (int num) =>
            //{
            //    return num > 10;
            //};

            ////way 2
            ////myDelegate del3 = num => num > 10;


            //var result = del3(num);
            //if (result)
            //{
            //    Console.WriteLine($"Number {num} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {num} is not greater than 10");
            //}
            #endregion


            #region Predicate<T> in-built delegate

            //Predicate<int> del4 = num => num > 10;

            //var result = del4(num);
            //if (result)
            //{
            //    Console.WriteLine($"Number {num} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {num} is not greater than 10");
            //}
            #endregion



            #region Extension Methods
            ////An extension method lets you add a new method to an existing class without changing the class.

            //int[] arr = new int[] { 1, 2, 3, 4 };
            //Console.WriteLine(arr.countElements());

            int[] arr = new int[] { 1, 2, 3, 4 };
            List<int> lst1 = arr.ConvertToList();
            foreach (var item in lst1)
            {
                Console.WriteLine($"{item}");
            }

            string[] days = new string[] { "Mon", "Tues", "Wed" };
            List<string> lst2 = days.ConvertToList();
            foreach (var item in lst2)
            {
                Console.WriteLine($"{item}");
            }
            #endregion

            #region Iterator
            IEnumerableDemo idemo = new IEnumerableDemo();
            //List<int> ilist = (List<int>)idemo.GetEnumerator();
            List<int> ilist = new List<int>();

            foreach (var item in ilist)
            {
                ilist.Add(item);
            }



            #endregion

        }

        public static bool check(int num)
        {
            return num > 10;
        }


    }
    public static class extensionMethodsDemo
    {
        public static int countElements(this int[] arr)
        {
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                cnt++;
            }
            return cnt;

            //foreach (var elem in arr)
            //{
            //    cnt++;
            //}
            //return cnt;
        }

        public static List<T> ConvertToList<T>(this IEnumerable<T> source)
        {
            List<T> list = new List<T>();
            foreach (var item in source)
            {
                list.Add(item);
            }
            return list;
        }


    }

    public class IEnumerableDemo : IEnumerable
    {
        private int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public IEnumerator GetEnumerator() {
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i];
            yield return num;
            }


        }

    }
}
