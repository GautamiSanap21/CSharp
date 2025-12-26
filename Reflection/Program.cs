using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string AssemblyPath = @"C:\Users\IET\Desktop\250845920024\CSharp\CSharpDemo\ClassLibraryForReflection\bin\Debug\ClassLibraryForReflection.dll";

            Assembly asm = Assembly.LoadFrom(AssemblyPath);

            Type[] AllTypes = asm.GetTypes();

            for (int i = 0; i < AllTypes.Length; i++)
            {
                Type type = AllTypes[i];
                Console.WriteLine(type);

                MethodInfo[] AllMethods = type.GetMethods();
                for (int j = 0; j < AllMethods.Length; j++)
                {
                    MethodInfo MInfo = AllMethods[j];
                    Console.WriteLine(MInfo);

                    ParameterInfo[] AllParameters = MInfo.GetParameters();

                    for (int k = 0; k < AllParameters.Length; k++)
                    {
                        ParameterInfo PInfo = AllParameters[k];
                        Console.WriteLine(PInfo);
                    }

                }
            }

        }
    }
}
