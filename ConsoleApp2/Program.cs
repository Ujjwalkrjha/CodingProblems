using System;

namespace RepliconTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //i/p = aaaabbbcca
            //o/p = a4b3c2a1
            string input = "aaa";
            char[] chararr = input.ToCharArray();
            int n = input.Length;
            int counter = 1;

            for (int i = 0; i < n; i++)
            {
                
                while (i < n - 1)
                {

                    if (chararr[i] == chararr[i + 1])
                    {
                        counter++;
                    }
                    if (chararr[i] != chararr[i + 1])
                    {
                        Console.WriteLine(chararr[i]);
                        Console.WriteLine(counter--);
                        counter = 1;
                        break;
                    }
                    i++;
                }
                

            }

            //if (chararr[n-1] == chararr[n - 2])
            //{
            //    int i = n-1;
            //    while (i > 0)
            //    {

            //        if (chararr[i] == chararr[i - 1])
            //        {
            //            counter++;
            //        }
            //        if (chararr[i] != chararr[i - 1])
            //        {
            //            Console.WriteLine(chararr[i]);
            //            Console.WriteLine(counter-1);
            //            break;
            //        }
            //        i--;
            //    }
            //}
            //else if (chararr[n-1] != chararr[n - 2])
            //{
            //    Console.WriteLine(chararr[n-1]);
            //    Console.WriteLine(counter);
            //}
        }
    }
}
