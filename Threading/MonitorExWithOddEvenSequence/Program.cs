using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


/**************************** Interview Question ************************************/

/*
  Using two threads print even and odd number in sequence. One thread prints even numbers 
  and another thread prints odd numbers.
  
   Thread T1 : 0,2,4,6…

   Thread T2 :1,3,5,7…

   Output: 0, 1,2,3,4,5,6,7…
 
   Answer: To solve this problem let’s use signalling mechanism using  wait () and pulse () method of Monitor class in C#.
           Other mechanism we can use AutoResetEvent or something.

           In below C# program example, we will use wait () method to make the thread waiting and pulse () method to signal 
           other thread.

 */

namespace MonitorExWithOddEvenSequence
{
    class Program
    {
        // upto the limit numbers will be printed.
        const int numberLimit = 10;

        static object lockObj = new object();

        static void Main(string[] args)
        {
            Thread oddThread = new Thread(Odd);
            Thread evenThread = new Thread(Even);

            evenThread.Start();

            //puase for 10 ms, to make sure even thread has started
            //or else odd thread may start first resulting other sequence.
            Thread.Sleep(100);

            oddThread.Start();

            oddThread.Join();
            evenThread.Join();
            Console.WriteLine("\nPrinting done!!!");

            Console.ReadKey();
        }

        static void Odd()
        {
            try
            {
                //hold lock as console is shared between threads.
                Monitor.Enter(lockObj);
                for (int i = 1; i <= numberLimit; i = i + 2)
                {
                    Console.Write(" " + i);

                    //Notify other thread that is to eventhread that I'm done you do your job
                    Monitor.Pulse(lockObj);

                    //I will wait here till even thread notify me
                    // Monitor.Wait(monitor);

                    // without this logic application will wait forever
                    bool isLast = i == numberLimit - 1;
                    if (!isLast)
                        Monitor.Wait(lockObj); //I will wait here till even thread notify me
                }
            }
            finally
            {
                //Release lock
                Monitor.Exit(lockObj);
            }
        }

        static void Even()
        {
            try
            {
                //hold lock
                Monitor.Enter(lockObj);
                for (int i = 0; i <= numberLimit; i = i + 2)
                {
                    Console.Write(" " + i);

                    //Notify other thread- here odd thread
                    //that I'm done, you do your job
                    Monitor.Pulse(lockObj);

                    //I will wait here till odd thread notify me
                    // Monitor.Wait(monitor);

                    bool isLast = i == numberLimit;
                    if (!isLast)
                        Monitor.Wait(lockObj);
                }
            }
            finally
            {
                Monitor.Exit(lockObj);
            }

        }
    }
}
