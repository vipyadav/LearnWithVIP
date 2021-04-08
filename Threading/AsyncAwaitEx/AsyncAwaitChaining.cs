using System;
using System.Threading.Tasks;

namespace AsyncAwaitEx
{
    public class AsyncAwaitChaining
    {
        public async Task Compute(int num)
        {
            Console.WriteLine("Calling Add as async...");
            int addition = await Add(num, 1);
            Console.WriteLine($"Addition is = {addition}");

            int sub = await Subtraction(addition, 1);
            Console.WriteLine($"Subtraction is = {sub}");

            Console.ReadKey();
        }

        private async Task<int> Subtraction(int a, int b)
        {
            await Task.Delay(1000);
            return a - b;
        }

        private async Task<int> Add(int a, int b)
        {
            await Task.Delay(4000);
            return a + b;
        }
    }
}
