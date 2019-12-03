using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExceptions
{
    class Program
    {
        async static Task Main(string[] args)
        {
            try
            {
                var one = Do("One", 500);
                var two = Do("Two", 500);

                await one;
                await two;

               // await Do("One", 500);
               // await Do("Two", 500);               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static Task Do(string name, int time)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"Task {name} starting");
                Thread.Sleep(time);
                Console.WriteLine($"Task {name} pre exception");
                throw new Exception($"Exception {name}");
            });
        }
    }
}
