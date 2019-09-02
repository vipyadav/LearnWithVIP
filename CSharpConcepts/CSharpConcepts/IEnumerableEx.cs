using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//How to make a C# class usable in a foreach statement

namespace CSharpConcepts
{
    public class IEnumerableEx
    {
        public void GetCars()
        {
            var cars = new Cars();

            foreach (var car in cars)
            {

            }
        }
    }

    public class Cars : IEnumerable
    {
        private Car[] carlist;

        //Create internal array in constructor.
        public Cars()
        {
            carlist = new Car[6]
                      {
                          new Car("Ford",1992),
                          new Car("Fiat",1988),
                          new Car("Buick",1932),
                          new Car("Ford",1932),
                          new Car("Dodge",1999),
                          new Car("Honda",1977)
                      };
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(carlist);
        }

        //private enumerator class
        private class MyEnumerator : IEnumerator
        {
            public Car[] carlist;
            int position = -1;

            //constructor
            public MyEnumerator(Car[] list)
            {
                carlist = list;
            }
            private IEnumerator getEnumerator()
            {
                return (IEnumerator)this;
            }


            //IEnumerator
            public bool MoveNext()
            {
                position++;
                return (position < carlist.Length);
            }

            //IEnumerator
            public void Reset()
            {
                position = -1;
            }

            //IEnumerator
            public object Current
            {
                get
                {
                    try
                    {
                        return carlist[position];
                    }

                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }
    }
}
