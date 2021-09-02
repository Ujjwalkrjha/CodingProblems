using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array" );
            string[] arr = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter the no of rotations");
            int r = int.Parse(Console.ReadLine());
            int n = arr.Length;
            leftRotate(arr, r, n);
            printArray(arr, n);
        }
        static void leftRotate(string[] arr, int d, int n)
        {
            for (int i = 0; i < d; i++)
                leftRotatebyOne(arr, n);
        }

        static void leftRotatebyOne(string[] arr, int n)
        {
            int i;
            string temp = arr[0];
            for (i = 0; i < n - 1; i++)
                arr[i] = arr[i + 1];

            arr[i] = temp;
        }

        /* utility function to print an array */
        static void printArray(string[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadLine();
        }
    
    }
}
