
using System.Runtime.CompilerServices;

namespace Abramyan_Rush
{
    public class TasksPart4
    {
        public void RunTest()
        {
            foreach (var number in Array80(15))
                Console.WriteLine(number);
        }

        private float Array21(int N, int K, int L)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float summ = 0f;

            for (int i = K; i <= L; i++)
            {
                summ += numbers[i];
            }

            return summ / (L - K) + 1f;
        }

        private float Array22(int N, int K, int L)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float summ = 0f;

            K++;

            for (int i = K; i < L; i++)
            {
                summ += numbers[i];
            }

            return summ;
        }

        private float Array23(int N, int K, int L)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            float summ = 0f;

            K++;

            for (int i = K; i < L; i++)
            {
                summ += numbers[i];
            }

            return summ / (K - L) - 1f;
        }

        private float Array24(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            float D = numbers[1] - numbers[0];

            float result;

            for (int i = 1; i < numbers.Count; i++)
            {
                result = numbers[0] + D * i;

                if (!AreAproximatelyEqual(numbers[i], result))
                    return 0;
            }

            return D;
        }

        private bool AreAproximatelyEqual(float numberOne, float numberTwo)
            => MathF.Abs(numberOne - numberTwo) < float.Epsilon;

        private float Array25(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            float D = numbers[1] / numbers[0];

            float step = D;

            float result;

            for (int i = 1; i < numbers.Count; i++)
            {
                result = numbers[0] * step;

                if (!AreAproximatelyEqual(numbers[i], result))
                    return 0;

                step *= D;
            }

            return D;
        }

        private float Array26(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            bool isOdd = numbers[0] % 2 != 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if ((numbers[i] % 2 != 0) == isOdd)
                    return i;

                isOdd = !isOdd;
            }

            return 0;
        }

        private float Array27(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int currentTurn = numbers[0] / (int)MathF.Abs(numbers[0]);

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] / (int)MathF.Abs(numbers[i]) == currentTurn)
                    return i;

                currentTurn = -currentTurn;
            }

            return 0;
        }

        private float Array28(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float min = float.MaxValue;

            for (int i = 0; i < numbers.Count; i += 2)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }

            return min;
        }

        private float Array29(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float max = float.MinValue;

            for (int i = 1; i < numbers.Count; i += 2)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }

            return max;
        }

        private (List<int> indexes, int countOfNumbers) Array30(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            List<int> numberIndexes = new();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                    numberIndexes.Add(i);
            }

            return (numberIndexes, numberIndexes.Count);
        }

        private (List<int> indexes, int countOfNumbers) Array31(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            List<int> numberIndexes = new();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i + 1] > numbers[i])
                    numberIndexes.Add(i);
            }

            return (numberIndexes, numberIndexes.Count);
        }

        private bool IsLocalMin(float leftNumber, float rightNumber, float number)
        {
            bool isLessThanLeft = number < leftNumber;
            bool isLessThanRight = number < rightNumber;

            return isLessThanLeft && isLessThanRight;
        }

        private bool IsLocalMax(float leftNumber, float rightNumber, float number)
        {
            bool isBiggerThanRight = number > rightNumber;
            bool isBiggerThanLeft = number > leftNumber;

            return isBiggerThanLeft && isBiggerThanRight;
        }

        private int Array32(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if (IsLocalMin(numbers[i - 1], numbers[i + 1], numbers[i]))
                    return i;
            }

            return 0;
        }

        private int Array33(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            int localMaxIndex = 0;

            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if (IsLocalMax(numbers[i - 1], numbers[i + 1], numbers[i]))
                    localMaxIndex = i;
            }

            return localMaxIndex;
        }

        private float Array34(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            int localMaxIndex = 0;

            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if (IsLocalMin(numbers[i - 1], numbers[i + 1], numbers[i]) && numbers[i] > numbers[localMaxIndex])
                    localMaxIndex = i;
            }

            return numbers[localMaxIndex];
        }

        private float Array35(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            int localMinIndex = 0;

            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if (IsLocalMin(numbers[i - 1], numbers[i + 1], numbers[i]) && numbers[i] < numbers[localMinIndex])
                    localMinIndex = i;
            }

            return numbers[localMinIndex];
        }

        //Ask-about-this mark \/
        private float Array36(int N) 
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float ordinaryNumber = float.MinValue;

            bool changedNumber = false;

            for(int i = 1; i < numbers.Count - 1; i++)
            {
                if(!IsLocalMin(numbers[i - 1], numbers[i + 1], numbers[i]) && !IsLocalMax(numbers[i - 1], numbers[i + 1], numbers[i]))
                {
                    if (numbers[i] > ordinaryNumber)
                    {
                        ordinaryNumber = numbers[i];
                        changedNumber = true;
                    }
                }
            }    

            if(changedNumber)
                return ordinaryNumber;

            return 0;
        }

        private int Array37(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            int countOfUprisingParts = 0;

            bool isUprising = false;

            for(int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] < numbers[i + 1] && !(numbers[i] > numbers[i + 1]))
                {
                    isUprising = true;
                }

                if (isUprising && numbers[i] > numbers[i + 1])
                {
                    countOfUprisingParts++;

                    isUprising = false;
                }
            }

            if (isUprising)
                countOfUprisingParts++;

            return countOfUprisingParts;
        }

        private int Array38(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            int countOfFallingParts = 0;

            bool isFalling = false;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] < numbers[i + 1] && !(numbers[i] > numbers[i + 1]))
                {
                    isFalling = true;
                }

                if (isFalling && numbers[i] > numbers[i + 1])
                {
                    countOfFallingParts++;

                    isFalling = false;
                }
            }

            if(isFalling)
                countOfFallingParts++;

            return countOfFallingParts;
        }

        //Ask-about-this mark \/
        private int Array39(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            int countOfMonotoneParts = 0;

            bool isFalling = false;
            bool isUprising = false;

            for(int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                    isFalling = true;
                else if (numbers[i] < numbers[i+1])
                    isUprising = true;

                if(isFalling && numbers[i] < numbers[i + 1])
                {
                    isFalling = false;

                    countOfMonotoneParts++;
                }

                if(isUprising && numbers[i] > numbers[i + 1])
                {
                    isUprising = false;

                    countOfMonotoneParts++;
                }
            }

            if (isUprising != isFalling)
                countOfMonotoneParts++;

            return countOfMonotoneParts;
        }

        private float Array40(int N, float R)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);
            
            float difference = float.MaxValue;

            float tempDifference;

            for(int i = 0; i < numbers.Count; i++)
            {
                tempDifference = MathF.Abs(numbers[i] - R);

                if (tempDifference < difference)
                    difference = tempDifference;
            }

            return difference;
        }

        private (int indexOne, int indexTwo) Array41(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float summ = float.MaxValue;

            int indexOne = 0;
            int indexTwo = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {

                if (numbers[i + 1] + numbers[i] > summ)
                {
                    indexOne = i;
                    indexTwo = i + 1;

                    summ = numbers[indexOne];
                }
            }

            return indexTwo > indexOne ? (indexOne, indexTwo) : (indexTwo, indexOne);
        }

        private (int indexOne, int indexTwo) Array42(int N, float R)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float difference = float.MaxValue;
            float tempDifference;

            int indexOne = 0;
            int indexTwo = 1;

            for(int i = 0; i < numbers.Count - 1; i++)
            {
                tempDifference = MathF.Abs((numbers[i] + numbers[i + 1]) - R);

                if(tempDifference < difference)
                {
                    difference = tempDifference;

                    indexOne = i;
                    indexTwo = i + 1;
                }
            }

            return indexTwo > indexOne ? (indexOne, indexTwo) : (indexTwo, indexOne);
        }

        //Ask about sort
        private int Array43(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N, 0, 50);

            numbers.Sort();

            int differentNumbersCount = 0;

            for(int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] != numbers[i + 1])
                    differentNumbersCount++;
            }

            return differentNumbersCount;
        }

        private (int indexOne, int indexTwo) Array44(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N, 0, 10);

            Dictionary<int, int> uniqueNumbers = new();

            for(int i = 0; i < numbers.Count; i++)
            {
                if (!uniqueNumbers.ContainsKey(numbers[i]))
                    uniqueNumbers.Add(numbers[i], i);
                else
                    return (i, uniqueNumbers[numbers[i]]);
            }

            return (0, 0);
        }

        //Ask-about-this-mark \/
        private (int indexOne, int indexTwo) Array45(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N, 0, 10);

            float difference = float.MaxValue;
            float tempDifference;

            int indexOne = 0;
            int indexTwo = 1;

            for(int i = 0; i < numbers.Count; i++)
            {
                for(int j = i + 1; j < numbers.Count; j++)
                {
                    tempDifference = MathF.Abs(numbers[i] - numbers[j]);

                    if(tempDifference < difference)
                    {
                        difference = tempDifference;

                        indexOne = i;
                        indexTwo = j;
                    }
                }
            }

            return indexTwo > indexOne ? (indexOne, indexTwo) : (indexTwo, indexOne);
        }

        private (int indexOne, int indexTwo) Array46(int N, int R)
        {
            var numbers = ListGenerators.CreateRandomIntList(N, 0, 10);

            float difference = float.MaxValue;
            float tempDifference;

            int indexOne = 0;
            int indexTwo = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        continue;
                    }

                    tempDifference = MathF.Abs(numbers[i] + numbers[j] - R);

                    if (tempDifference < difference)
                    {
                        difference = tempDifference;

                        indexOne = i;
                        indexTwo = j;
                    }
                }
            }

            return indexTwo > indexOne ? (indexOne, indexTwo) : (indexTwo, indexOne);
        }

        //Ask-about-this-mark \/
        private int Array47(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            HashSet<int> uniqueNumbers = new HashSet<int>();
            HashSet<int> notUniqueNumbers = new HashSet<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (uniqueNumbers.Contains(numbers[i]) && !notUniqueNumbers.Contains(numbers[i]))
                    notUniqueNumbers.Add(numbers[i]);
                else
                    uniqueNumbers.Add(numbers[i]);
            }

            return (int)MathF.Abs(notUniqueNumbers.Count - uniqueNumbers.Count);
        }

        //Ask-about-this-mark \/
        private int Array48(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            HashSet<int> uniqueNumbers = new();
            Dictionary<int, int> notUniqueNumbers = new();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (uniqueNumbers.Contains(numbers[i]) && !notUniqueNumbers.ContainsKey(numbers[i]))
                    notUniqueNumbers.Add(numbers[i], 2);
                else if (uniqueNumbers.Contains(numbers[i]) && notUniqueNumbers.ContainsKey(numbers[i]))
                {
                    notUniqueNumbers[numbers[i]]++;
                }
                else
                    uniqueNumbers.Add(numbers[i]);
            }

            return notUniqueNumbers.Values.Max();
        }

        private int Array49(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            for(int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] + 1 != numbers[i + 1])
                    return i;
            }

            return 0;
        }

        //Ask-about-this-mark \/
        private int Array50(int N)
        {
            var numbers = ListGenerators.CreateRandomIntList(N);

            int countOfInversions = 0;

            for(int i = 0; i < numbers.Count; i++)
            {
                for(int j = 0; j < numbers.Count; j++)
                {
                    if (i == j)
                        continue;

                    if (numbers[i] > numbers[j] && i < j)
                        countOfInversions++;
                }
            }

            return countOfInversions;
        }

        private (List<float> newA, List<float> newB) Array51(int N)
        {
            var A = ListGenerators.CreateRandomFloatList(N);
            var B = ListGenerators.CreateRandomFloatList(N);

            var tempList = A;

            A = B; 
            B = tempList;

            return (A, B);
        }

        private List<float> Array52(int N)
        {
            var A = ListGenerators.CreateRandomFloatList(N);

            List<float> B = new();

            foreach(var number in A)
            {
                if (number < 5)
                    B.Add(number * 2f);
                else
                    B.Add(number / 2f);
            }

            return B;
        }

        private List<float> Array53(int N)
        {
            var A = ListGenerators.CreateRandomFloatList(N);

            var B = ListGenerators.CreateRandomFloatList(N);

            float max = float.MinValue;

            for(int i = 0; i < N; i++)
            {
                if (A[i] > max)
                    max = A[i];

                if(B[i] > max)
                    max = B[i];
            }

            List<float> C = new();

            for(int i = 0; i < N; i++)
            {
                C.Add(max);
            }

            return C;
        }

        private (int length, List<int>) Array54(int N)
        {
            var A = ListGenerators.CreateRandomIntList(N);

            List<int> B = new();

            for(int i = 0; i < A.Count; i++)
            {
                if (A[i] % 2 == 0)
                    B.Add(A[i]);
            }

            return (B.Count, B);
        }

        private (int length, List<int>) Array55(int N)
        {
            var A = ListGenerators.CreateRandomIntList(N);

            List<int> B = new();

            for (int i = 1; i < A.Count; i += 2)
            {
                B.Add(A[i]);
            }

            return (B.Count, B);
        }

        private (int length, List<int>) Array56(int N)
        {
            var A = ListGenerators.CreateRandomIntList(N);

            List<int> B = new();

            for (int i = 3; i < A.Count; i += 3)
            {
                B.Add(A[i]);
            }

            return (B.Count, B);
        }

        private List<int> Array57(int N)
        {
            var A = ListGenerators.CreateRandomIntList(N);

            List<int> B = new(N);

            int indexToAdd = 0;

            for(int i = 0; i < A.Count; i += 2)
            {
                B[indexToAdd] = A[i];

                B[^indexToAdd] = A[i + 1];

                indexToAdd++;
            }

            return B;
        }

        private List<float> Array58(int N) 
        {
            var A = ListGenerators.CreateRandomFloatList(N);

            List<float> B = new(N);

            float summ = 0f;

            for(int i = 0; i < A.Count; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    summ += A[j];
                }

                B.Add(summ);

                summ = 0f;
            }

            return B;
        }

        private List<float> Array59(int N)
        {
            var A = ListGenerators.CreateRandomFloatList(N);

            List<float> B = new(N);

            float summ = 0f;

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    summ += A[j];
                }

                B.Add(summ / (i + 1));

                summ = 0f;
            }

            return B;
        }

        private List<float> Array60(int N)
        {
            var A = ListGenerators.CreateRandomFloatList(N);

            List<float> B = new(N);

            float summ = 0f;

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i; j < N - 1; j++)
                {
                    summ += A[j];
                }

                B.Add(summ);

                summ = 0f;
            }

            return B;
        }

        private List<float> Array61(int N)
        {
            var A = ListGenerators.CreateRandomFloatList(N);

            List<float> B = new();

            float summ = 0f;

            for(int i = 0; i < A.Count; i++)
            {
                summ += A[i];
            }

            float numberToAdd;

            for(int i = 0; i < A.Count; i++)
            {
                numberToAdd = summ / A.Count - i;

                B.Add(numberToAdd);

                summ -= A[i];
            }

            return B;
        }

        private (List<float>, List<float>) Array62(int N)
        {
            var A = ListGenerators.CreateRandomFloatList(N);

            List<float> B = new();
            List<float> C = new();

            foreach (var number in A)
            {
                if(number > 0)
                    B.Add(number);
                else if(number < 0)
                    C.Add(number);
            }

            return (B, C);
        }

        private List<float> Array63(int N)
        {
            var A = ListGenerators.CreateRandomFloatList(5);
            var B = ListGenerators.CreateRandomFloatList(5);

            List<float> C = new();

            int indexA = 0;
            int indexB = 0;

            for(int i = 0; i < 10; i++)
            {
                if (indexA > 5 || (A[indexA] > B[indexB] && indexB < 5))
                {
                    C.Add(B[indexB]);

                    indexB++;
                }
                else
                {
                    C.Add(A[indexA]);

                    indexA++;
                }
            }

            return C;
        }

        private List<int> Array64(List<int> A, List<int> B, List<int> C) 
        { 
            int indexA = 0;
            int indexB = 0;
            int indexC = 0;

            int countOfIterations = (A.Count + B.Count + C.Count) - 2;

            List<int> D = new();

            for (int i = 0; i < countOfIterations; i++)
            {
                if(indexA < A.Count && (indexB >= B.Count || A[indexA] >= B[indexB]) && (indexC >= C.Count || A[indexC] > C[indexC]))
                {
                    D.Add(A[indexA]);
                    indexA++;
                }
                else if (indexB < B.Count && (indexC >= C.Count || B[indexB] > C[indexC]))
                {
                    D.Add(B[indexB]);
                    indexB++;
                }
                else
                {
                    D.Add(C[indexC]);
                    indexC++;
                }
            }

            return D;
        }

        private List<float> Array65(int N, int K)
        {
            var A = ListGenerators.CreateRandomFloatList(N);

            float number = A[K];

            for(int i = 0; i < A.Count; i++)
            {
                A[i] += number;
            }

            return A;
        }

        private List<int> Array66(int N) 
        {
            var A = ListGenerators.CreateRandomIntList(N);

            int even = A.Where(x => x % 2 == 0).First(); 

            for(int i = 0; i < A.Count; i++)
            {
                if (A[i] % 2 == 0)
                    A[i] += even;
            }    

            return A;
        }

        private List<int> Array67(int N)
        {
            var A = ListGenerators.CreateRandomIntList(N);

            int odd = A.Where(x => x % 2 != 0).First();

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] % 2 != 0)
                    A[i] += odd;
            }

            return A;
        }

        private List<float> Array68(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            (float max, int index) maxTuple = (float.MinValue, 0);
            (float min, int index) minTuple = (float.MaxValue, 0);

            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > maxTuple.max)
                {
                    maxTuple.max = numbers[i];
                    maxTuple.index = i;
                }

                if (numbers[i] < minTuple.min)
                {
                    minTuple.min = numbers[i];
                    minTuple.index = i;
                }
            }

            numbers[maxTuple.index] = minTuple.min;
            numbers[minTuple.index] = maxTuple.max;

            return numbers;
        }

        private List<float> Array69(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float temp;

            for(int i = 0; i < numbers.Count - 1; i++)
            {
                temp = numbers[i];

                numbers[i] = numbers[i + 1];
                numbers[i + 1] = temp;
            }

            return numbers;
        }

        private List<float> Array70(int N) 
        {
            var numbers = ListGenerators.CreateRandomFloatList(10);

            List<float> first = numbers.GetRange(0, 5);
            List<float> second = numbers.GetRange(5, 5);

            numbers = second.Concat(first).ToList();

            return numbers;
        }

        private List<float> Array71(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(10);

            numbers.Reverse();

            return numbers;
        }

        private List<float> Array72(int N, int K, int L)
        {
            var numbers = new List<float> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//ListGenerators.CreateRandomFloatList(10);

            List<float> cutPart = numbers.GetRange(K, (L - K) + 1);

            cutPart.Reverse();

            for(int i = K; i <= L; i++)
            {
                numbers[i] = cutPart[i - K];
            }

            return numbers;
        }

        private List<float> Array73(int N, int K, int L)
        {
            var numbers = ListGenerators.CreateRandomFloatList(10);

            List<float> cutPart = numbers.GetRange(K + 1, L - K);

            cutPart.Reverse();

            for (int i = K; i <= L; i++)
            {
                numbers[i] = cutPart[i - K];
            }

            return numbers;
        }

        private List<float> Array74(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(10);

            int minIndex = 0;
            int maxIndex = 0;

            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                    maxIndex = i;
                else if (numbers[i] < numbers[minIndex])
                    minIndex = i;
            }

            int startingIndex = minIndex > maxIndex ? maxIndex : minIndex;
            int endingIndex = minIndex < maxIndex ? maxIndex : minIndex;

            for (int i = startingIndex + 1; i < endingIndex; i++)
            {
                numbers[i] = 0;
            }

            return numbers;
        }

        private List<float> Array75(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(10);

            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                    maxIndex = i;
                else if (numbers[i] < numbers[minIndex])
                    minIndex = i;
            }

            int startingIndex = minIndex > maxIndex ? maxIndex : minIndex;
            int endingIndex = minIndex < maxIndex ? maxIndex : minIndex;

            List<float> cutPart = numbers.GetRange(startingIndex, endingIndex - startingIndex + 1);

            for(int i = startingIndex; i <= endingIndex; i++)
            {
                numbers[i] = cutPart[endingIndex - i];
            }

            return numbers;
        }

        private List<float> Array76(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(10);

            List<float> changedNumbers = numbers;

            for(int i = 1; i < numbers.Count - 1; i++)
            {
                if (IsLocalMax(numbers[i - 1], numbers[i + 1], numbers[i]))
                    changedNumbers[i] = 0;
            }

            return changedNumbers;
        }

        private List<float> Array77(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(10);

            List<float> changedNumbers = numbers;

            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if (IsLocalMin(numbers[i - 1], numbers[i + 1], numbers[i]))
                    changedNumbers[i] = numbers[i] * numbers[i];
            }

            return changedNumbers;
        }

        private List<float> Array78(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            List<float> changedNumbers = numbers;

            changedNumbers[0] = (numbers[0] + numbers[1]) / 2f;
            changedNumbers[0] = (numbers[N - 1] + numbers[N - 2]) / 2f;

            for(int i = 1; i < numbers.Count - 1; i++)
            {
                changedNumbers[i] = (numbers[i] + numbers[i - 1] + numbers[i + 1]) / 3f;
            }

            return changedNumbers;
        }

        private List<float> Array79(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float previousNumber = numbers[0];
            float currentNumber;

            for(int i = 1; i < numbers.Count; i++)
            {
                currentNumber = numbers[i];

                numbers[i] = previousNumber;

                previousNumber = currentNumber;
            }

            numbers[0] = 0;

            return numbers;
        }

        private List<float> Array80(int N)
        {
            var numbers = ListGenerators.CreateRandomFloatList(N);

            float previousNumber = numbers[N - 1];
            float currentNumber;

            for (int i = N - 1; i >= 0; i--)
            {
                currentNumber = numbers[i];

                numbers[i] = previousNumber;

                previousNumber = currentNumber;
            }

            numbers[N - 1] = 0;

            return numbers;
        }
    }
}
