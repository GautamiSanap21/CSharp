namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string filepath = @"C:\Users\IET\Desktop\250845920024\CSharp\CSharpDemo\FileIO\Files\file1.txt";

            FileStream fs = new FileStream(filepath,FileMode.Append, FileAccess.Write);

            //for writing
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello");
            sw.Flush();
            sw.Close();
            fs.Close();



            FileStream fs2 = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            //for reading
            StreamReader sr = new StreamReader(fs2);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            fs2.Close();
        }
    }
}
