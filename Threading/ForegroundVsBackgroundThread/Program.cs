using System;
using System.Threading;

namespace ForegroundVsBackgroundThread
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundThread();
            //BackgroundThread();
            Console.WriteLine("Main Thread Quits..!");
        }

        static void ForegroundThread()
        {
            Thread objThread = new Thread(WorkerThread);
            objThread.Name = "Foreground Thread";
            objThread.Start();
        }

        static void BackgroundThread()
        {
            Thread background = new Thread(WorkerThread);
            background.Name = "Background Thread";
            background.IsBackground = true;
            background.Start();           
        }

        private static void WorkerThread()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("{0} is Running......", Thread.CurrentThread.Name);
                Thread.Sleep(1000);
            }
            Console.WriteLine("{0} Quits..!", Thread.CurrentThread.Name);
        }
    }
}
