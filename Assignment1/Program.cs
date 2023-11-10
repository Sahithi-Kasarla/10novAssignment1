using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 2,4,8,5 };
            matrix[1] = new int[] { 24, 45,0 };
            matrix[2] = new int[] { 7,4,81};
            //Accessing and storing
            int element = matrix[0][1];
            Console.WriteLine("stored values are");
            for (int i = 0; i < matrix.Length; i++)
            {
               // Console.WriteLine("the inner values are" + (i + 1));
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.WriteLine(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            //modifying the 3rd elememt in the second row to have 15
                matrix[1][2] = 15;
            Console.WriteLine("after modifying the matrix");
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine("the inner values are" + (i + 1));
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.WriteLine(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            //
            object[][] objectMatrix = new object[2][];
            objectMatrix[0] = new object[] { 42, "Hello", 3.14 };
            objectMatrix[1] = new object[] { true, 'A', DateTime.Now };

            Console.WriteLine("\n Display the object Matrix");
            for (int i = 0; i < objectMatrix.Length; i++)
            {
                for (int j = 0; j < objectMatrix[i].Length; j++)
                {
                    Console.WriteLine($"Type: {objectMatrix[i][j].GetType()},\t Value: {objectMatrix[i][j]}");
                }
                Console.ReadKey();
            }

        }
    }
}
