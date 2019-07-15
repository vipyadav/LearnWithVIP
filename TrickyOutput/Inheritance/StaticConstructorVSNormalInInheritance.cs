using System;

// TCS Interview Question

namespace LearnWithVIP.Inheritance
{
    public class Base
    {
        static Base()
        {
            Console.WriteLine("Static: Base");
        }

        public Base()
        {
            Console.WriteLine("Public: Base");
        }
    }

    public class Derived : Base
    {
        static Derived()
        {
            Console.WriteLine("Static: Derived");
        }

        public Derived()
        {
            Console.WriteLine("Public: Derived");
        }
    }

    public class StaticConstructorVSNormalInInheritance
    {
       public void Test()
        {
            var derived = new Derived();
        }
    }
}

// Output: 
//      Static: Derived
//      Static: Base
//      Public: Base
//      Public: Derived
