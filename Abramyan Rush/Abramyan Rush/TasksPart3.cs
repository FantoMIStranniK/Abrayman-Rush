
using Microsoft.VisualBasic.FileIO;
using System.Net;
using System.Net.NetworkInformation;

namespace Abramyan_Rush
{
    public class TasksPart3
    {
        public void RunTest()
        {

        }

        #region MinMax

        private (float min, float max) MinMax1(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float max = float.MinValue;
            float min = float.MaxValue;

            foreach(var number in numbers)
            {
                if(number >= max)
                    max = number;
                if(number <= min)
                    min = number;
            }

            return (min, max);
        }

        private float MinMax2(int N) 
        { 
            List<(float sideA, float sideB)> rectangels = ListGenerators.CreateFloatTupleList(N);

            float minSquare = float.MaxValue;

            for(int i = 0; i < rectangels.Count; i++)
            {
                float square = rectangels[i].sideA * rectangels[i].sideB;

                if (square < minSquare)
                    minSquare = square;
            }

            return minSquare;
        }

        private float MinMax3(int N)
        {
            List<(float sideA, float sideB)> rectangels = ListGenerators.CreateFloatTupleList(N);

            float maxPerimeter = float.MinValue;

            for(int i = 0; i < rectangels.Count; i++)
            {
                float perimeter = rectangels[i].sideA * 2f + rectangels[i].sideB * 2f;

                if (perimeter > maxPerimeter)
                    maxPerimeter = perimeter;
            }

            return maxPerimeter;
        }

        private int MinMax4(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            int minIndex = 0;

            for(int i = 0; i < numbers.Count; i++)
                if (numbers[i] < numbers[minIndex])
                    minIndex = i;
            
            return minIndex;    
        }

        private (int index, float highestDensity) MinMax5(int N)
        {
            List<(float m, float v)> parts = ListGenerators.CreateFloatTupleList(N);

            float highestDensity = float.MinValue;
            int highestDensityIndex = -1;

            for(int i = 0; i < parts.Count; i++)
            {
                float density = parts[i].m / parts[i].v;

                if(density > highestDensity)
                {
                    highestDensity = density;
                    highestDensityIndex = i;
                }
            }

            return (highestDensityIndex, highestDensity);
        }

        private (int indexOfMin, int indexOfMax) MinMax6(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < numbers[minIndex])
                    minIndex = i;

                if (numbers[i] >= numbers[maxIndex])
                    maxIndex = i;
            }

            return (minIndex, maxIndex);
        }

        private (int indexOfMin, int indexOfMax) MinMax7(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] <= numbers[minIndex])
                    minIndex = i;

                if (numbers[i] > numbers[maxIndex])
                    maxIndex = i;
            }

            return (minIndex, maxIndex);
        }

        private (int indexOfFirstMin, int indexOfLastMin) MinMax8(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);
            
            int minIndexOne = 0;
            int minIndexTwo = 0;

            for(int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < numbers[minIndexOne])
                    minIndexOne = i;

                if (numbers[i] <= numbers[minIndexTwo])
                    minIndexTwo = i;
            }

            return (minIndexOne, minIndexTwo);
        }

        private (int indexOfFirstMax, int indexOfLastMax) MinMax9(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int maxIndexOne = 0;
            int maxIndexTwo = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > numbers[maxIndexOne])
                    maxIndexOne = i;

                if (numbers[i] >= numbers[maxIndexTwo])
                    maxIndexTwo = i;
            }

            return (maxIndexOne, maxIndexTwo);
        }

        private int MinMax10(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                    maxIndex = i;

                if (numbers[i] < numbers[minIndex])
                    minIndex = i;
            }

            return minIndex < maxIndex ? minIndex : maxIndex;
        }

        private int MinMax11(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] >= numbers[maxIndex])
                    maxIndex = i;

                if (numbers[i] <= numbers[minIndex])
                    minIndex = i;
            }

            return minIndex > maxIndex ? minIndex : maxIndex;
        }

        private int MinMax12(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int minNumber = int.MaxValue;

            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < minNumber && numbers[i] > 0)
                    minNumber = numbers[i];
            }

            return minNumber == int.MaxValue ? 0 : minNumber;
        }

        private int MinMax13(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);
            
            int maxNumberIndex = 0;

            for(int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > numbers[maxNumberIndex] && numbers[i] % 2 != 0)    
                    maxNumberIndex = i;
            }

            return maxNumberIndex;
        }

        private float MinMax14(float B)
        {
            var numbers = ListGenerators.CreateRandomFloatList(10);

            float number = float.MaxValue;

            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] < number && number > B)
                    number = numbers[i];
            }

            return number;
        }

        private float MinMax15(float B, float C)
        {
            var numbers = ListGenerators.CreateRandomFloatList(10);
            
            float number = float.MinValue;

            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > number && number > B && number < C)
                    number = numbers[i];
            }

            return number;
        }

        private int MinMax16(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int minNumberIndex = 0;

            for(int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < numbers[minNumberIndex])
                    minNumberIndex = i;
            }

            return minNumberIndex;
        }

        private int MinMax17(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int maxNumberIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] >= numbers[maxNumberIndex])
                    maxNumberIndex = i;
            }

            return numbers.Count - (maxNumberIndex + 1);
        }

        private int MinMax18(int N)
        {
            var maxIndexes = MinMax9(N);

            return (maxIndexes.indexOfLastMax- maxIndexes.indexOfFirstMax) + 1;
        }

        private int MinMax19(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int min = int.MaxValue;
            int countOfMins = 0;

            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    countOfMins = 0;
                }

                if (numbers[i] == min)
                {
                    countOfMins++;
                }
            }

            return countOfMins;
        }

        private int MinMax20(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int min = int.MaxValue;
            int max = int.MinValue;

            int countOfMax = 0;
            int countOfMins = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    countOfMins = 0;
                }

                if (numbers[i] == min)
                {
                    countOfMins++;
                }

                if (numbers[i] > max)
                {
                    max = numbers[i];
                    countOfMax = 0;
                }

                if (numbers[i] == max)
                {
                    countOfMax++;
                }
            }

            return countOfMins + countOfMax;
        }

        private float MinMax21(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float min = float.MaxValue;
            float max = float.MinValue;

            float summ = 0f;

            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];

                if (numbers[i] > max)
                    max = numbers[i];

                summ += numbers[i];
            }

            return (summ - (max + min)) / (numbers.Count - 2);
        }

        private (float min1, float min2) MinMax22(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float min1 = float.MaxValue;
            float min2 = float.MinValue;

            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min2 && numbers[i] != min1)
                {
                    if (numbers[i] < min1)
                    {
                        min2 = min1;
                        min1 = numbers[i];
                    }
                    else
                    {
                        min2 = numbers[i];
                    }
                }
            }

            return (min1, min2);
        }

        private (float max1, float max2, float max3) MinMax23(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float max1 = float.MinValue;
            float max2 = float.MinValue;
            float max3 = float.MinValue;

            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max3 && numbers[i] != max1 && numbers[i] != max2)
                {
                    if (numbers[i] > max2)
                    {
                        if (numbers[i] > max1)
                        {
                            max3 = max2;
                            max2 = max1;
                            max1 = numbers[i];
                        }
                        else
                        {
                            max3 = max2;
                            max2 = numbers[i];
                        }
                    }
                    else
                    {
                        max3 = numbers[i];
                    }
                }

                if(max1 == max2)
                {
                    max2 = numbers[i];
                }

                if(max1 == max3 || max2 == max3)
                {
                    max3 = numbers[i];
                }
            }

            return (max1, max2, max3);
        }

        private float MinMax24(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float maxSumm = float.MinValue;

            float summ = 0f;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                summ = numbers[i] + numbers[i + 1];

                if(summ > maxSumm)
                    maxSumm = summ;
            }

            return maxSumm;
        }

        private (int firstIndex, int secondIndex) MinMax25(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float minMult = float.MaxValue;
            float mult = 0f;

            int minMultIndex1 = 0;
            int minMultIndex2 = 0;

            for(int i = 0; i < numbers.Count - 1; i++)
            {
                mult = numbers[i] * numbers[i + 1];

                if(mult < minMult)
                {
                    minMultIndex1 = i;
                    minMultIndex2 = i + 1;

                    minMult = mult;
                }
            }

            return minMultIndex1 < minMultIndex2 ? (minMultIndex1, minMultIndex2) : (minMultIndex2, minMultIndex1);
        }

        private int MinMax26(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int maxLength = 0;
            int length = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                    length++;
                else
                    if(length > maxLength)
                        maxLength = length;
            }

            return maxLength;
        }

        private (int startingIndex, int length) MinMax27(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N, 0, 2);

            int previousNumber = 0;

            int numberIndex = 0;
            int maxNumberIndex = 0;

            int length = 0;
            int maxLength = 0;

            for(int i = 0; i < numbers.Count; i++)
            {
                if(previousNumber == numbers[i])
                {
                    length++;
                }
                else
                {
                    if(length > maxLength)
                    {
                        maxLength = length;
                        maxNumberIndex = numberIndex;
                    }

                    numberIndex = i;
                    length = 1;
                }

                previousNumber = numbers[i];
            }

            return (maxNumberIndex, maxLength);
        }

        private (int startingIndex, int length) MinMax28(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N, 0, 2);

            int numberIndex = 0;
            int maxNumberIndex = 0;

            int length = 0;
            int maxLength = 0;

            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    length++;
                    maxNumberIndex = numberIndex;
                }
                else
                {
                    if (length > maxLength)
                        maxLength = length;

                    maxNumberIndex = i;
                    numberIndex = 0;
                }
            }

            return (maxNumberIndex, maxLength);
        }

        private int MinMax29(int N) 
        {
            var numbers = ListGenerators.CreateRandomIntList(N, 0, 10);

            int min = int.MaxValue;

            for(int i = 0; i < numbers.Count; i++)
                if (numbers[i] < min)
                    min = numbers[i];

            int length = 1;
            int maxLength = 0;

            for(int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == min)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        length++;
                    }
                }
                else
                {
                    if(length > maxLength)
                    {
                        maxLength = length;
                        length = 1;
                    }
                }
            }

            return maxLength;
        }

        private int MinMax30(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N, 0, 10);

            int max = int.MinValue;

            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] > max)
                    max = numbers[i];

            int length = 1;
            int minLength = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == max)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        length++;
                    }
                }
                else
                {
                    if (length < minLength)
                    {
                        minLength = length;
                        length = 1;
                    }
                }
            }

            return minLength;
        }

        #endregion

        #region Array

        private List<int> Array1(int N)
        {
            List<int> numbers = new List<int>();

            int numberToAdd = 1;

            for(int i = 0; i < N; i++)
            {
                numbers.Add(numberToAdd);

                numberToAdd += 2;
            }

            return numbers;
        }

        private List<int> Array2(int N)
        {
            List<int> numbers = new List<int>();

            int numberToAdd = 2;

            for (int i = 0; i < N; i++)
            {
                numbers.Add(numberToAdd);

                numberToAdd *= 2;
            }

            return numbers;
        }

        private List<int> Array3(int N, int A, int D)
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i <= N; i++)
            {
                numbers.Add(A);

                A = A + D * i;
            }

            return numbers;
        }
        private List<int> Array4(int N, int A, int D)
        {
            List<int> numbers = new List<int>();

            int powerD = D;

            for (int i = 0; i < N; i++)
            {
                numbers.Add(A);

                A = A * powerD;

                powerD *= D;
            }

            return numbers;
        }

        private List<int> Array5(int N, int F1 = 1, int F2 = 1)
        {
            List<int> numbers = new List<int>
            {
                F1,
                F2
            };

            for (int i = 2; i < N; i++)
                numbers.Add(numbers[i - 2] + numbers[i - 1]);

            return numbers;
        }

        private List<int> Array6(int N, int A, int B)
            => Array5(N, A, B);

        private List<int> Array7(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            numbers.Reverse();

            return numbers;
        }

        private (List<int>, int countOfNumbers) Array8(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            List<int> oddNumbers = new List<int>();

            for(int i = 0; i < N; i++)
            {
                if (numbers[i] % 2 != 0)
                    oddNumbers.Add(numbers[i]);
            }

            return (oddNumbers, oddNumbers.Count);
        }

        private (List<int>, int countOfNumbers) Array9(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < N; i++)
            {
                if (numbers[i] % 2 == 0)
                    evenNumbers.Add(numbers[i]);
            }

            evenNumbers.Reverse();

            return (evenNumbers, evenNumbers.Count);
        }

        private (List<int> oddNumbers, List<int> evenNumbers, int oddNumbersCount, int evenNumbersCount) Array10(int N) 
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();
            
            for(int i = 0; i < N; i++)
            {
                if (numbers[i] % 2 == 0)
                    evenNumbers.Add(numbers[i]);
                else
                    oddNumbers.Add(numbers[i]);
            }

            evenNumbers.Reverse();

            return (oddNumbers, evenNumbers, oddNumbers.Count, evenNumbers.Count);
        }

        private List<float> Array11(int N, int K)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            var chosenNumbers = new List<float>();

            for(int i = K; i < numbers.Count; i += K)
                chosenNumbers.Add(numbers[i]);

            return chosenNumbers;
        }

        private List<float> Array12(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            var chosenNumbers = new List<float>();

            for (int i = 2; i < numbers.Count; i += 2)
                chosenNumbers.Add(numbers[i]);

            return chosenNumbers;
        }

        private List<float> Array13(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            var chosenNumbers = new List<float>();
            
            for(int i = N - 1; i >= 0; i-= 2)
                chosenNumbers.Add(numbers[i]);

            return numbers;
        }

        private (List<float> evenNumbers, List<float> oddNumbers) Array14(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            List<float> evenIndexNumbers = new List<float>();
            List<float> oddIndexNumbers = new List<float>();

            for(int i = 0; i < numbers.Count - 1; i += 2)
            {
                evenIndexNumbers.Add(numbers[i + 1]);
                oddIndexNumbers.Add(numbers[i]);
            }

            return (evenIndexNumbers, oddIndexNumbers);
        }

        private (List<float> oddNumbers, List<float> evenNumbers) Array15(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            List<float> evenIndexNumbers = new List<float>();
            List<float> oddIndexNumbers = new List<float>();

            for (int i = 0; i < numbers.Count - 1; i += 2)
            {
                evenIndexNumbers.Add(numbers[i + 1]);
                oddIndexNumbers.Add(numbers[i]);
            }

            evenIndexNumbers.Reverse();

            return (oddIndexNumbers, evenIndexNumbers);
        }

        private List<float> Array16(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);
            
            var outputNumbers = new List<float>();

            int reversedIndex = N - 1;

            for(int i = 0; i < N; i++)
            {
                outputNumbers.Add(numbers[i]);

                outputNumbers.Add(numbers[reversedIndex - i]);
            }

            return outputNumbers;
        }

        private List<float> Array17(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            var outputNumbers = new List<float>();

            int reversedIndex = N - 1;

            for (int i = 0; i < N - 1; i++)
            {
                outputNumbers.Add(numbers[i]);
                outputNumbers.Add(numbers[i + 1]);

                outputNumbers.Add(numbers[reversedIndex - i]);
                outputNumbers.Add(numbers[reversedIndex - (i + 1)]);
            }

            return outputNumbers;
        }

        private int Array18()
        { 
            var numbers = ListGenerators.CreateRandomIntList(10);

            for (int i = 0; i < 10; i++)
                if (numbers[i] < numbers[9])
                    return numbers[i];

            return 0;
        }

        private int Array19()
        {
            var numbers = ListGenerators.CreateRandomIntList(10);

            int suitableNumber = 0;

            for (int i = 0; i < 10; i++)
                if (numbers[i] > numbers[0] && numbers[i] < numbers[9])
                    suitableNumber = numbers[i];

            return suitableNumber;
        }

        private float Array20(int N, int K, int L)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float summ = 0f;

            for (int i = K; i <= L; i++)
                summ += numbers[i];

            return summ;
        }
        #endregion
    }
}
