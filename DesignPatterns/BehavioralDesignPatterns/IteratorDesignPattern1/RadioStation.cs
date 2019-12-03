using System;

namespace IteratorDesignPattern1
{
    public class FMRadio
    {
        public FMRadio(double frequency, string name)
        {
            Frequency = frequency;
            Name = name;
        }

        public double Frequency { get; set; }
        public string Name { get; set; }
    }
}
