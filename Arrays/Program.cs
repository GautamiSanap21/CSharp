namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            #region integer array

            //int[] arr = new int[5];

            //to explicitly insert elements in array
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;


            //user input
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Enter number: " + (i+1));
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //reads the single element from an array
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[2]);
            //Console.WriteLine(arr[3]);
            //Console.WriteLine(arr[4]);


            //for loop to print the array
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //forEach loop to print the array
            //foreach (int element in arr)
            //{
            //    Console.WriteLine(element);
            //}

            #endregion

            #region String Array

            String[] namesArr = new string[5];
            //user input
            for (int i = 0; i < namesArr.Length; i++)
            {
                Console.WriteLine("Enter Name: " + (i + 1));
                namesArr[i] = Console.ReadLine();
            }

            foreach (String name in namesArr)
            {
                Console.WriteLine("Mr/Ms "+name);
            }


            #endregion


        }
    }
}
