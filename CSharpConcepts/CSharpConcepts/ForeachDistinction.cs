using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class ForeachDistinction
    {
        public void DisplayItems()
        {
            var myClass = new MyClass2();

            var list = new List<double>();

            foreach (var item in myClass)
            {

            }
        }
    }

    public class MyClass1 : IEnumerable
    {
        public MyClass1()
        {
            myData = new List<double>(new double[] { 3.4, 1.2, 6.2 });
        }

        private List<double> myData;

        public IEnumerator GetEnumerator()
        {
            foreach (double val in myData)
            {
                yield return val;
            }
        }
    }

    public class MyClass2 : IEnumerable<double> //Specify your return type in the angle brackets.
    {
        public MyClass2()
        {
            myData = new List<double>(new double[] { 3.4, 1.2, 6.2 });
        }

        private List<double> myData;

        //Put your enumerator code in this method. Specify your return type in the angle brackets again here.
        public IEnumerator<double> GetEnumerator()
        {
            foreach (double val in myData)
            {
                yield return val;
            }
        }

        //This method is also needed, but usually you don't need to change it from this.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }   
    }
}
