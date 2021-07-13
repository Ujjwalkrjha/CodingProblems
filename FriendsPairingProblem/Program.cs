using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsPairingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of people.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(Program.countFriendsPairings(n));
            Console.ReadLine();

            // Driver code 

        }
        public static int countFriendsPairings(int n)
        {
            int[] dp = new int[n+1];
            //Logic for filling up dp to get friends
            for (int i = 0; i <= n; i++)
            {
                if (i <= 2)
                    dp[i] = i;
                else
                    dp[i] = dp[i - 1] + (i - 1) * dp[i - 2];
            }

            return dp[n];
        }

    }
}
