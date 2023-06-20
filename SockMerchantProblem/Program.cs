using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchantProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter the no of socks.");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the socks");
            int[] ar = { 1, 1, 2, 2, 3 ,3,3,5};

            Console.WriteLine(Program.sockMerchant(ar.Length, ar));
            Console.ReadLine();

        }
        public static int sockMerchant(int n, int[] ar)
        {
            int pairs = 0;
            HashSet<int> set = new HashSet<int>();
            foreach (int i in ar)
            {
                if (set.Contains(i)) continue;
                int[] matchedItems = Array.FindAll(ar, x => i == x);
                int occurrencies = matchedItems.Length;
                if (occurrencies > 1)
                    pairs += (occurrencies / 2);
                set.Add(i);
            }
         return pairs;
        }
        
    }
}
