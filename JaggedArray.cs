using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class JaggedArray
    {
        private int[][] jagged;
        public JaggedArray(int rows, int cols, bool randomise = false) 
        {
            Recreate(rows, cols, randomise);
        }
        public void Recreate(int rows, int cols, bool randomise = false)
        {
            Random random = new Random();
            jagged = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                jagged[i] = new int[cols];

            }
            if (randomise)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        jagged[i][j] = random.Next();
                    }
                }
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.WriteLine($"введите элемент {i + 1} {j + 1}");
                        jagged[i][j] = int.Parse(Console.ReadLine());
                    }
                }
            }
        }
        public override string ToString()
        {
            string result = "";
            
            for (int i = 0; i < jagged.Length; i++)
            {
                
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    result += jagged[i][j].ToString();
                    
                }
                result += "\n";
            }
            return result;
        }
        public double GetAverage() 
        {
            int s = 0;
            int c = 0;
            for (int i = 0; i < jagged.Length; i++)
            {
                
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    s += jagged[i][j];
                    c += 1;

                }
            }
            return (double)s / c;
            

        }
        public double[] GetAverageAll()
        {
            double[] averages = new double[jagged.Length];
            for(int i = 0;i < jagged.Length; i++)
            {
                double sum = 0;
                int c = 0;
                foreach (int value in jagged[i])
                {
                    sum += value;
                    c++;
                }
                averages[i] = sum/c;
            }
            return averages;
        }
        public void index()
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    if (jagged[i][j]%2==0)
                    {
                        jagged[i][j]=i*j;
                    }
                }
            }
        }

        //

    }

    
}
