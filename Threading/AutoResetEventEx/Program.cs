using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/**************************** Interview Question ************************************/

/* Print “Hello” and “World” via 2 thread but one after another like 
     Hello World
     Hello World
 */

namespace AutoResetEventEx
{
    class Program
    {
        static AutoResetEvent _blockThreadHello = new AutoResetEvent(false);
        static AutoResetEvent _blockThreadWorld = new AutoResetEvent(true);

        static void Main(string[] args)
        {

            Thread threadHello = new Thread(new ThreadStart(Hello));
            Thread threadWorld = new Thread(new ThreadStart(World));

            threadHello.Start();
            threadWorld.Start();

            Console.ReadKey();
        }

        static void Hello()
        {
            for (int i = 0; i < 10; i++)
            {
                // block thread World()  while Hello() is executing  
                _blockThreadWorld.WaitOne();


                // Set was called to free the block on thread 1, continue executing the code  
                Console.Write("Hello ");

                // finished executing the code in Hello() thread, so unblock World() thread
                _blockThreadHello.Set();

            }
        }

        static void World()
        {

            for (int i = 0; i < 10; i++)
            {

                // block thread Hello() while World() is executing
                _blockThreadHello.WaitOne();

                // Set was called to free the block on thread 1, continue executing the code  
                Console.WriteLine("World");

                // finished executing the code in thread World(), so unblock thread  Hello()
                _blockThreadWorld.Set();
            }

        }
    }
}
