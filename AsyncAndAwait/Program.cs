using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{//P.S. Task.Delay(x) creates an async task only unless we use .wait() at the end of it
    class Program
    {
        static void Main(string[] args)
        {
            DummyMethod();
            DummyAsyncMethod();
            Console.WriteLine("Main method code");
            Console.Read();
        }

        private static async void DummyAsyncMethod()
        {
            await Task.Delay(5000);
            Console.WriteLine("Async Task complete.");
        }

        private static  void DummyMethod()
        {
            Task.Delay(5000).Wait();
            Console.WriteLine("Sync Task complete.");
        }
    }
}
