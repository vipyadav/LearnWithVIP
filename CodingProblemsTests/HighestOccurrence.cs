using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    public class HighestOccurrence
    {
        public static int GetMaxFrequencyOfGreatestNumber(int[] array)
        {
            if (array == null || array.Length <= 0)
                return 0;

            int maxNumber = 0, numMaxFrequency = 1;
            foreach (var num in array)
            {
                if (maxNumber < num)
                {
                    maxNumber = num;
                    numMaxFrequency = 1;
                }
                else if (maxNumber == num)
                {
                    numMaxFrequency++;
                }
            }
            return numMaxFrequency;
        }

        public static int GetDigitWhichHasHighestOccurrenceBruteForce(int[] arr)
        {
            var maxCounter = 0;
            var maxPosition = 0;

            var size = arr.Length;

            for (var i = 0; i < size; i++)
            {
                var counter = 0;
                for (var j = 0; j < size; j++)
                {
                    if (arr[i] == arr[j])
                        counter++;
                }
               
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxPosition = i;
                }
            }
            return arr[maxPosition];
        }

        public static int FindHighestRepeatingElement(int[] array)
        {
            var size = array.Length;
            int counter = 0, currCounter = 1, freqNum = 0;
            for (var i = 0; i < size - 1; i++)
            {
                var key = array[i];

                for (var j = i + 1; j < size; j++)
                {
                    if (key == array[j] && freqNum != key)
                    {
                        currCounter++;
                    }
                }

                if (counter < currCounter)
                {
                    counter = currCounter;
                    currCounter = 1;
                    freqNum = key;
                }
            }
            return freqNum;
        }
    }
}
