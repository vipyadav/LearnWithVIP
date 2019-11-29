using System;
using System.Collections;

namespace GenericCollections
{
     public class HashtableEx
    {
        public void RunExample()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "welcome");
            hashtable.Add(2, "to");
            hashtable.Add(3, "tutorials");
            hashtable.Add(4, "of Vipin");
            hashtable.Add(5, "C#");

            // Get a collection of the keys.
            ICollection key = hashtable.Keys;

            // Print Hash table 
            Console.WriteLine("Hashtable Contains:");
            
            foreach (var val in key)
            {
                Console.WriteLine(val + "-" + hashtable[val]);
            }
            
            // --------- Remove() Method ----------' 
            hashtable.Remove("4");

            // --------- Using Count Property 
            Console.WriteLine("Total Number of Elements in has1: "+ hashtable.Count);

            // Creating 2nd Hashtable 
            Hashtable myTable2 = new Hashtable();

            // Adding elements in Hashtable    
            myTable2.Add(1, "C#");
            myTable2.Add(2, "data structures");
            myTable2.Add(3, "quiz");

            // check if both the Hashtables are equal or not 
            Console.WriteLine(hashtable.Equals(myTable2));

            // check if the HashTable contains the required Value or not. 
            if (hashtable.ContainsValue("C#"))
                Console.WriteLine("Hashtable contains the Value");
            else
                Console.WriteLine("Hashtable doesn't contain the Value");

            if (hashtable.ContainsKey(2))
                Console.WriteLine("Hashtable contains the key 2");
            else
                Console.WriteLine("Hashtable doesn't contain the key 2");
        }
    }
}
