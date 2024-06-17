using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks
{
    [MemoryDiagnoser(false)]
    public class Palindrome
    {
        [Benchmark]
        public void checkPalindrome1()
        {

            string? sequence = "12321";
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
