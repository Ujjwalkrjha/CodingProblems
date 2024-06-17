using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntegerPalindrome();
            AnySequence();

        }

        public static void IntegerPalindrome()
        
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
                while (n > 0)
                {
                    r = n % 10;
                    sum = (sum* 10) + r;
                    n = n / 10;
                }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
            Console.ReadLine();
        }

        public static void AnySequence()
        {
            Console.Write("Enter the Sequence: ");
            string? sequence = Console.ReadLine();
            if (sequence is not null)
            {
                var reverceSequence = new string(sequence.Reverse().ToArray());
                if (sequence == reverceSequence)
                {
                    Console.WriteLine("Sequence is a palindrome.");
                }                    
                else Console.WriteLine("Sequence is not a palindrome.");
            }
            else Console.WriteLine("Sequence is null.");
        }
    }
}
