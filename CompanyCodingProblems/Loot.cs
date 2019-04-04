using System;

namespace CodingProblems
{
    public class Loot
    {
        public int GetMaxLootValues(int[] houseValues)
        {
            var numberOfHouses = houseValues.Length;

            switch (numberOfHouses)
            {
                case 0:
                    return 0;
                case 1:
                    return houseValues[0];
                case 2:
                    return Math.Max(houseValues[0], houseValues[1]);
            }

            //represent the maximum value stolen so far after reaching house i. 
            var stolenValuesSum = new int[numberOfHouses];

            stolenValuesSum[0] = houseValues[0];
            stolenValuesSum[1] = Math.Max(houseValues[0], houseValues[1]);

            for (var i = 2; i < numberOfHouses; i++)
                stolenValuesSum[i] = Math.Max(houseValues[i] + stolenValuesSum[i - 2], stolenValuesSum[i - 1]);

            return stolenValuesSum[numberOfHouses - 1];
        }
    }
}
