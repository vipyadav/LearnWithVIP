using System;

namespace CSharpVersionIteratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubjects scienceSubjects = new Science();

            Console.WriteLine("=========== Science subjects ==========");
            
            // Using IEnumerable.
            foreach (var item in scienceSubjects)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n======== Arts subjects ==============");

            ISubjects artsSubjects = new Arts();
            foreach (var item in artsSubjects)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
