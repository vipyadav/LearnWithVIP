using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************** Interview Question ************************************/

namespace LINQ
{
    public class PrimeNumber
    {
        //Find All Prime Numbers from the List<int> through LINQ
        public static IEnumerable<int> GetAllPrimeNumbers(List<int> numbers)
        {
            IEnumerable<int> primes =
                        numbers.Where(number => Enumerable.Range(2, (int)Math.Sqrt(number) - 1)
                                .All(divisor => number % divisor != 0));

            return primes;
        }
    }
}
