using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyArray
    {
        private int[] array;
        private Random random;
        public MyArray(int Size, bool randomise = false) 
        {
            Recreate(Size, randomise);
        }
        public void Recreate(int Size, bool randomise = false)
        {
            random = new Random();
            array = new int[Size];
            if (randomise)
            {
                for (int i = 0; i < Size; i++)
                {
                    array[i] = random.Next();
                }
            }
            else
            {

                for (int i = 0; i < Size; i++)
                {
                    Console.WriteLine($"введите элемент {i + 1}");
                    array[i] = int.Parse(Console.ReadLine());

                }
            }
        }
        public override string ToString()
        {
            string result = string.Empty;
            foreach(int elem in array) 
            {
                result += elem.ToString();
                result += ", ";

            }
            return result.Substring(0, result.Length - 2);
        }
        public double GetAverage() 
        {
            double s = 0;
            
            for (int i = 0;i < array.Length;i++)
            {
                s += array[i];
                
            }
            return s / array.Length;
        }
        public void PopElement()
        {
            array = array.Where(x => Math.Abs(x)<=100).ToArray();

        }
        public void RemoveDuplicates()
        {
            array = array.Distinct().ToArray();

        }
    }

}
