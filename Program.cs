using ConsoleApp1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestMyArray();

            //TestMatrix();

            TestJaggedArray();


        }
        static void TestMyArray()
        {
            MyArray lst = new MyArray(10);
            Console.WriteLine(lst.ToString());
            Console.WriteLine(lst.GetAverage());
            lst.PopElement();
            Console.WriteLine(lst.ToString());
            lst.RemoveDuplicates();
            Console.WriteLine(lst.ToString());
        }
        static void TestMatrix()
        {
            Matrix lst = new Matrix(3, 3);
            Console.WriteLine(lst.ToString());
            Console.WriteLine(lst.GetAverage());
            Console.WriteLine(lst.CalculateDeterminant());
        }

        static void TestJaggedArray()
        {
            JaggedArray lst = new JaggedArray(2, 5);
            Console.WriteLine(lst.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(lst.GetAverage());
            Console.WriteLine("\n");
            foreach(double value in lst.GetAverageAll())
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("\n");
            lst.index();
            Console.WriteLine(lst.ToString());
            
            
        }
    }
}