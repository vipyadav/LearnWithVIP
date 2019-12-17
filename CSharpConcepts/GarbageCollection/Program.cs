using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    class Program
    {
        static string staticString = "fooooooooooooooooooooooooooooooooo";
        static long staticLong = Int64.MaxValue;
        static void Main(string[] args)
        {
            int[] arrSmall = new int[250];
            int[] arrLarge = new int[85000];

            Console.WriteLine("\n********************* Small Array[250] **********************\n");

            Console.WriteLine("Initial Stage in Generation : " + GC.GetGeneration(arrSmall));

            GC.Collect();
            Console.WriteLine("After 1st GC.Collect in Generation : " + GC.GetGeneration(arrSmall));

            GC.Collect();
            Console.WriteLine("After 2nd GC.Collect in Generation : " + GC.GetGeneration(arrSmall));

            GC.Collect();

            Console.WriteLine("\n\n********************* Large Array[85000] ******************\n");

            Console.WriteLine("Initial Stage of in Generation : " + GC.GetGeneration(arrLarge));

            GC.Collect();
            Console.WriteLine("After 1st GC.Collect in Generation : " + GC.GetGeneration(arrLarge));

            GC.Collect();
            Console.WriteLine("After 2nd GC.Collect in Generation : " + GC.GetGeneration(arrLarge));

            GC.Collect();

            Console.WriteLine("\n\n********************* List ****************************\n");
            var list = new List<string>();

            Console.WriteLine("Initial Stage of in Generation : " + GC.GetGeneration(list));

            GC.Collect();
            Console.WriteLine("After 1st GC.Collect in Generation : " + GC.GetGeneration(list));

            GC.Collect();
            Console.WriteLine("After 2nd GC.Collect in Generation : " + GC.GetGeneration(list));

            GC.Collect();

            Console.WriteLine("\n\n********************* Static String ****************************\n");

            Console.WriteLine("Initial Stage of in Generation : " + GC.GetGeneration(staticString));

            GC.Collect();
            Console.WriteLine("After 1st GC.Collect in Generation : " + GC.GetGeneration(staticString));

            GC.Collect();
            Console.WriteLine("After 2nd GC.Collect in Generation : " + GC.GetGeneration(staticString));

            GC.Collect();

            Console.WriteLine("\n\n********************* Static Long ****************************\n");

            Console.WriteLine("Initial Stage of in Generation : " + GC.GetGeneration(staticLong));

            GC.Collect();
            Console.WriteLine("After 1st GC.Collect in Generation : " + GC.GetGeneration(staticLong));

            GC.Collect();
            Console.WriteLine("After 2nd GC.Collect in Generation : " + GC.GetGeneration(staticLong));

            GC.Collect();
            Console.ReadKey();
        }
    }
}
