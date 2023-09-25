
using System.ComponentModel.Design;

namespace Abramyan_Rush
{
    public static class SeriesUtilities
    {
        private static Random rand = new Random();

        public static List<float> CreateRandomFloatList(int length)
        {
            List<float> numbers = new();

            for (int i = 0; i < length; i++)
                numbers.Add(rand.NextSingle() * rand.Next(0, 100));

            return numbers;
        }

        public static List<int> CreateRandomIntList(int length, int lowerLimit = -100, int upperLimit = 100)
        {
            List<int> numbers = new();

            for (int i = 0; i < length; i++)
                numbers.Add(rand.Next(lowerLimit, upperLimit));

            return numbers;
        }

        public static List<int> CreateListEndingWithZero(int lowerLimit = -100, int upperLimit = 100)
        {
            List<int> numbers = new();

            int nextIndex = 1;

            while(nextIndex != 0)
            {
                nextIndex = rand.Next(lowerLimit, upperLimit);

                numbers.Add(nextIndex);
            }

            return numbers;
        }

        public static List<List<int>> CreateIntListOfLists(int length, int lengthOfList, bool isEndingWithZero = false, int lowerLimit = -100, int upperLimit = 100)
        {
            List<List<int>> lists = new();

            for(int i = 0; i < length; i++)
            {
                if(isEndingWithZero)
                    lists.Add(CreateListEndingWithZero(lowerLimit, upperLimit));
                else
                    lists.Add(CreateRandomIntList(lengthOfList, lowerLimit, upperLimit));
            }

            return lists;
        }
    }
}
