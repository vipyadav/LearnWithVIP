using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class AmbiguousMethodCall
    {
        public void Fun(int a, float b)
        {

        }

        public void Fun(float a, int b)
        {

        }
    }

    public static class AmbiguousMethodCallEx
    {
        public static void Execute()
        {
            var obj = new AmbiguousMethodCall();
            //obj.Fun(2,3); // Compile time error => The call is ambiguous between the following methods or properties

        }
    }
}
