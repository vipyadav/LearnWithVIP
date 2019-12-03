using System;

namespace IteratorDesignPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            RadioCollection channels = new RadioCollection();
            channels.AddChannel(new FMRadio(91.1, "Radio City"));
            channels.AddChannel(new FMRadio(92.7, "Big FM"));
            channels.AddChannel(new FMRadio(93.5, "Red FM"));
            channels.AddChannel(new FMRadio(94.3, "Radio One"));
            channels.AddChannel(new FMRadio(98.3, "Radio Mirchi"));
            channels.AddChannel(new FMRadio(104.0, "Fever 104"));

            // Create iterator
            IIterator iterator = channels.CreateIterator();

            Console.WriteLine("============ For loop ===========================");

            for (FMRadio radio = iterator.First(); !iterator.IsDone; radio = iterator.Next())
            {
                Console.WriteLine($"FM Radio Name : {radio.Name} & Frequency : {radio.Frequency}");
            }

            Console.WriteLine("============ While loop ===========================");

            iterator = channels.CreateIterator(); // Here We can use Reset() method of Iterator

            FMRadio fMChannel = iterator.First();
            while (!iterator.IsDone)
            {
                Console.WriteLine($"FM Radio Name : {fMChannel.Name} & Frequency : {fMChannel.Frequency}");
                fMChannel = iterator.Next();
            }

            Console.ReadKey();
        }
    }
}
