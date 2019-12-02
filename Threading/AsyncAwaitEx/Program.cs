using System;
using System.Threading.Tasks;

namespace AsyncAwaitEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am start of Main().");

            Task responseTask = Task.Run(() => BackgroundTask());

            //try
            //{
            //    responseTask.Wait();
            //}
            //catch (Exception e)
            //{
            //    if (responseTask.IsFaulted)
            //    {
            //    }
            //}
            Console.WriteLine("I am end of Main().");

            Console.ReadKey();
            Console.WriteLine("I am end of Program.");
        }

        public static async Task BackgroundTask()
        {
            Console.WriteLine("I am start of BackgroundTask().");
            await Fun1();
            Console.WriteLine("I am in between of Fun1() & Fun2().");
            await Fun2();
            Console.WriteLine("I am end of BackgroundTask().");
        }

        private static async Task Fun1()
        {
            Console.WriteLine("I am  Fun1().");
        }

        private static Task<int> Fun2()
        {
            throw new NotImplementedException();
        }
    }
}
