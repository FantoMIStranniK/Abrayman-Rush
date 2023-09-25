
using System.Diagnostics.CodeAnalysis;
using System.Resources;

namespace Abramyan_Rush
{
    public class TasksPart2
    {
        public void RunTest()
        {
            Series38(3);
        }

        #region For

        private void For1(int N, int K)
        {
            for (int i = 0; i < N; i++)
                Console.WriteLine(K);
        }

        private void For2(int A, int B)
        {
            for (int i = A; i <= B; i++)
                Console.WriteLine(i);
        }

        private void For3(int A, int B)
        {
            for (int i = B - 1; i > A; i--)
                Console.WriteLine(i);

            Console.WriteLine(B - A - 1);
        }

        private void For4(float price)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i * price);
        }

        private void For5(float price)
        {
            for (float i = 0.1f; i <= 1f; i += 0.1f)
                Console.WriteLine(i * price);
        }

        private void For6(float price)
        {
            for (float i = 1f; i <= 2f; i += 0.1f)
                Console.WriteLine(i * price);
        }

        private int For7(int A, int B)
        {
            int summ = 0;

            for (int i = A; i <= B; i++)
                summ += i;

            return summ;
        }

        private int For8(int A, int B)
        {
            int mult = 1;

            for (int i = A; i <= B; i++)
                mult *= i;

            return mult;
        }

        private int For9(int A, int B)
        {
            int summ = 1;

            for (int i = A; i <= B; i++)
                summ += i * i;

            return summ;
        }

        private float For10(int N)
        {
            float summ = 0f;

            for (int i = 1; i <= N; i++)
                summ += 1f / i;

            return summ;
        }

        private float For11(int N)
        {
            float summ = 0f;

            for (int i = 0; i <= N; i++)
            {
                float nextNumber = N + i;

                summ += nextNumber * nextNumber;
            }

            return summ;
        }

        private float For12(int N)
        {
            float mult = 1f;

            float number = 1.1f;

            for (int i = 0; i < N; i++)
            {
                mult *= number;

                number += 0.1f;
            }

            return mult;
        }

        private float For13(int N)
        {
            float summ = 0f;

            float number = 1.1f;

            int turn = 1;

            for (int i = 0; i < N; i++)
            {
                summ += number * turn;

                number += 0.1f;

                turn = -turn;
            }

            return summ;
        }

        private int For14(int N)
        {
            int result = 0;

            for (int i = 1; i <= N; i++)
                result += (i * 2) - 1;

            return result;
        }

        private float For15(float A, int N)
        {
            float result = 1f;

            for (int i = 0; i < N; i++)
                result *= A;

            return result;
        }

        private void For16(float A, int N)
        {
            float squareNumber = A;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(squareNumber);

                squareNumber *= A;
            }
        }

        private float For17(float A, int N)
        {
            float squareNumber = A;
            float summ = 1f;

            for (int i = 0; i < N; i++)
            {
                summ += squareNumber;

                squareNumber *= A;
            }

            return summ;
        }

        private float For18(float A, int N)
        {
            float squareNumber = A;
            float summ = 1f;

            int turn = -1;

            for (int i = 0; i < N; i++)
            {
                summ += squareNumber * turn;

                turn = -turn;

                squareNumber *= A;
            }

            return summ;
        }

        private float For19(int N)
        {
            float factorial = 1f;

            for (int i = 2; i <= N; i++)
                factorial *= i;

            return factorial;
        }

        private float For20(int N)
        {
            float summ = 0f;
            float factorial = 1f;

            for (int i = 1; i <= N; i++)
            {
                factorial *= i;

                summ += factorial;
            }

            return summ;
        }

        private float For21(int N)
        {
            float summ = 0f;
            float factorial = 1f;

            for (int i = 1; i <= N; i++)
            {
                factorial *= i;

                summ += 1f / factorial;
            }

            return summ;
        }

        private float For22(float X, int N)
        {
            float summ = 0f;
            float square = X;
            float factorial = 1f;

            for (int i = 1; i <= N; i++)
            {
                factorial *= i;

                summ += square / factorial;

                square *= X;
            }

            return summ;
        }

        private float For23(float X, int N)
        {
            float result = 0f;
            float square = X;
            float factorial = 1f;

            int turn = 1;

            for (int i = 1; i <= N; i += 2)
            {
                factorial *= i;

                result += square / factorial * turn;

                square *= X * X;

                turn = -turn;

                factorial *= i + 1f;
            }

            return result;
        }

        private float For24(float X, int N)
        {
            float result = 1f;
            float square = X;
            float factorial = 1f;

            int turn = -1;

            for (int i = 2; i <= N; i += 2)
            {
                factorial *= i;

                result += (square / factorial) * turn;

                square *= X * X;

                turn = -turn;

                factorial *= i + 1f;
            }

            return result;
        }

        private float For25(float X, int N)
        {
            float result = 0f;
            float squareNumber = X;

            int turn = 1;

            for (int i = 1; i <= N; i++)
            {
                result += squareNumber / i * turn;

                squareNumber *= X;

                turn = -turn;
            }

            return result;
        }

        private float For26(float X, int N)
        {
            float result = 0f;
            float squareNumber = X;

            int turn = 1;

            for (int i = 1; i <= N; i += 2)
            {
                result += squareNumber / i * turn;

                squareNumber *= X * X;

                turn = -turn;
            }

            return result;
        }

        private float For27(float X, int N)
        {
            float squareNumber = X;
            float result = X;

            int upperPart = 1;
            int bottomPart = 1;

            for (int i = 1; i <= N; i++)
            {
                squareNumber *= X * X;

                upperPart *= 2 * i - 1;
                bottomPart *= 2 * i;

                result += upperPart * squareNumber / bottomPart * (2f * i + 1f);
            }

            return result;
        }

        private float For28(float X, int N)
        {
            float squareNumber = X;
            float result = 1;

            int upperPart = 1;
            int bottomPart = 1;
            int turn = 1;

            for (int i = 1; i < N - 1; i++)
            {
                squareNumber *= X;

                upperPart *= 2 * i - 3;
                bottomPart *= 2 * i;

                result += (upperPart * squareNumber / bottomPart) * turn;

                turn = -turn;
            }

            return result;

        }

        private void For29(int N, float A, float B)
        {
            float H = (B - A) / N;

            Console.WriteLine(H);

            for (int i = 1; i <= N; i++)
                Console.WriteLine(A + H * i);
        }

        private void For30(int N, float A, float B)
        {
            float H = (B - A) / N;

            Console.WriteLine(H);

            for (int i = 1; i <= N; i++)
            {
                float result = MathF.Sin(A + H * i);

                Console.WriteLine(result);
            }
        }

        private void For31(int N)
        {
            float previousNumber = 2f;

            for (int i = 0; i < N; i++)
            {
                float nextNumber = 2f + 1f / previousNumber;

                Console.WriteLine(nextNumber);

                previousNumber = nextNumber;
            }
        }

        private void For32(int N)
        {
            float previousNumber = 2f;

            for (int i = 1; i <= N; i++)
            {
                float nextNumber = (previousNumber + 1f) / i;

                Console.WriteLine(nextNumber);

                previousNumber = nextNumber;
            }
        }

        private void For33(int N)
        {
            int firstPreviousNumber = 1;
            int secondPreviousNumber = 1;

            Console.WriteLine(firstPreviousNumber);
            Console.WriteLine(secondPreviousNumber);

            for (int i = 2; i <= N; i++)
            {
                int result = secondPreviousNumber - firstPreviousNumber;

                Console.WriteLine(result);

                secondPreviousNumber = firstPreviousNumber;

                firstPreviousNumber = result;
            }
        }
        private void For34(int N)
        {
            float firstPreviousNumber = 1f;
            float secondPreviousNumber = 2f;

            Console.WriteLine(firstPreviousNumber);
            Console.WriteLine(secondPreviousNumber);

            for (int i = 2; i <= N; i++)
            {
                float result = (secondPreviousNumber + 2f * firstPreviousNumber) / 3f;

                Console.WriteLine(result);

                secondPreviousNumber = firstPreviousNumber;

                firstPreviousNumber = result;
            }
        }
        private void For35(int N)
        {
            float firstPreviousNumber = 1f;
            float secondPreviousNumber = 2f;
            float thirdPreviousNumber = 3f;

            Console.WriteLine(firstPreviousNumber);
            Console.WriteLine(secondPreviousNumber);

            for (int i = 2; i <= N; i++)
            {
                float result = firstPreviousNumber - secondPreviousNumber - 2f * thirdPreviousNumber;

                Console.WriteLine(result);

                thirdPreviousNumber = secondPreviousNumber;

                secondPreviousNumber = firstPreviousNumber;

                firstPreviousNumber = result;
            }
        }

        private float For36(int N, int K)
        {
            float summ = 0f;

            float powerNumber = 1f;

            for (int i = 1; i <= N; i++)
            {
                powerNumber = i;

                for (int j = 0; j < K; j++)
                {
                    powerNumber *= i;
                }

                summ += powerNumber;
            }

            return summ;
        }

        private float For37(int N)
        {
            float summ = 0f;
            float powerNumber = 1f;

            for (int i = 0; i < N; i++)
            {
                powerNumber = i;

                for (int j = 0; j < i; j++)
                {
                    powerNumber *= i;
                }

                summ += powerNumber;
            }

            return summ;
        }

        private float For38(int N)
        {
            float summ = 0f;
            float powerNumber = 1f;

            for (int i = 0; i < N; i++)
            {
                powerNumber = i;

                for (int j = 0; j < N - i; j++)
                {
                    powerNumber *= i;
                }

                summ += powerNumber;
            }

            return summ;
        }

        private void For39(int A, int B)
        {
            for (int i = A; i < B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private void For40(int A, int B)
        {
            int currentNumber = A;

            for (int i = 0; i < B - A; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(currentNumber);
                }

                currentNumber += 1;
            }
        }
        #endregion

        #region While

        private float While1(float A, float B)
        {
            while (B >= A)
                A -= B;

            return A;
        }

        private int While2(float A, float B)
        {
            int countOfParts = 0;

            while (A >= B)
            {
                A -= B;
                countOfParts++;
            }

            return countOfParts;
        }
        private (int result, float leftover) While3(float N, float K)
        {
            int countOfParts = 0;

            while (K >= N)
            {
                N -= K;
                countOfParts++;
            }

            return (countOfParts, N);
        }

        private bool While4(int N)
        {
            while (N > 0)
                N -= 3;

            return N == 0 ? true : false;
        }

        private int While5(int N)
        {
            int K = 0;

            while (N >= 2)
            {
                N /= 2;

                K++;
            }

            return K;
        }

        private float While6(int N)
        {
            float factorial = 1f;

            while (N >= 2)
            {
                factorial *= N;

                N -= 2;
            }

            return factorial;
        }

        private int While7(int N)
        {
            int K = N;

            int squareNumber = K * K;

            while (N / squareNumber > N)
            {
                K--;

                squareNumber = K * K;
            }

            return K;
        }

        private int While8(int N)
        {
            int K = N;

            while (K * K <= N)
                K++;

            return K - 1;
        }

        private int While9(int N)
        {
            int squareNumber = 3;

            int K = 1;

            while (squareNumber <= N)
            {
                K++;

                squareNumber *= 3;
            }

            return K;
        }

        private int While10(int N)
        {
            int powerNumber = 3;

            int K = 0;

            while (powerNumber < N)
            {
                K++;

                powerNumber *= 3;
            }

            return K;
        }

        private int While11(int N)
        {
            int K = 0;
            int summ = 0;

            while (summ <= N)
            {
                K++;

                summ += K;
            }

            return K;
        }

        private int While12(int N)
        {
            int K = 0;
            int summ = 0;

            while (summ + K + 1! <= N)
            {
                K++;

                summ += K;
            }

            return K;
        }

        private (int K, float summ) While13(int A)
        {
            int K = 1;
            float summ = 0;

            while (summ <= A)
            {
                summ += 1f / K;

                K++;
            }

            return (K, summ);
        }

        private (int K, float summ) While14(int A)
        {
            int K = 1;
            float summ = 0;

            while (summ <= A)
            {
                summ += 1f / K;

                K++;
            }

            summ -= 1f / K;
            K--;

            return (K, summ);
        }

        private (int K, float summ) While15(float P)
        {
            int K = 0;
            float S = 1000;

            while (S <= 1100)
            {
                K++;

                S += (S * P) / 100f;
            }

            return (K, S);
        }

        private (int K, float summ) While16(float P)
        {
            int K = 0;
            float S = 10;

            while (S <= 200)
            {
                K++;

                S += (S * P) / 100f;
            }

            return (K, S);
        }

        private void While17(int N)
        {
            while (N > 0)
            {
                Console.WriteLine(N % 10);

                N /= 10;
            }
        }

        private (int countOfNumbers, int summOfNumbers) While18(int N)
        {
            int summ = 0;
            int counter = 0;

            while (N > 0)
            {
                counter++;

                summ += N % 10;

                N /= 10;
            }

            return (counter, summ);
        }

        private int While19(int N)
        {
            int result = 0;

            while (N > 0)
            {
                result *= 10 + N % 10;

                N /= 10;
            }

            return result;
        }

        private bool While20(int N)
        {
            while (N > 0)
            {
                if (N % 10 == 2)
                    return true;

                N /= 10;
            }

            return false;
        }

        private bool While21(int N)
        {
            int leftover = 0;

            while (N > 0)
            {
                leftover = N % 10;

                if (leftover % 2 != 0)
                    return true;

                N /= 10;
            }

            return false;
        }

        private bool While22(int N)
        {
            int divider = 2;

            while (divider < N - 1)
            {
                if (divider % 2 == 0)
                    return false;

                divider++;
            }

            return true;
        }

        private int While23(int A, int B)
        {
            while (A != 0 && B != 0)
            {
                if (A > B)
                    A %= B;
                else
                    B %= A;
            }

            return A + B;
        }

        private bool While24(int N)
        {
            int firstPreviousElement = 1;
            int secondPreviousElement = 1;

            int result = 0;

            while (result <= N)
            {
                result = firstPreviousElement + secondPreviousElement;

                if (result == N)
                    return true;

                secondPreviousElement = firstPreviousElement;
                firstPreviousElement = result;
            }

            return false;
        }

        private int While25(int N)
        {
            int firstPreviousElement = 1;
            int secondPreviousElement = 1;
            int result = 0;

            while (result < N + 1)
            {
                result = firstPreviousElement + secondPreviousElement;

                secondPreviousElement = firstPreviousElement;
                firstPreviousElement = result;
            }

            return result;
        }

        private (int previousNumber, int folowingNumber) While26(int N)
        {
            int firstPreviousElement = 1;
            int secondPreviousElement = 1;
            int result = 0;

            while (result < N + 1)
            {
                result = firstPreviousElement + secondPreviousElement;

                secondPreviousElement = firstPreviousElement;
                firstPreviousElement = result;
            }

            return (secondPreviousElement, secondPreviousElement + firstPreviousElement);
        }

        private int While27(int N)
        {
            int firstPreviousElement = 1;
            int secondPreviousElement = 1;
            int result = 0;

            int index = 2;

            while (result < N + 1)
            {
                index++;

                result = firstPreviousElement + secondPreviousElement;

                secondPreviousElement = firstPreviousElement;
                firstPreviousElement = result;

            }

            return index;
        }

        private (int index, float previousNumber, float number) While28(float epsilon)
        {
            float previousNumber = 2;
            float result = 0;

            int index = 0;

            while (MathF.Abs(previousNumber - result) < epsilon)
            {
                index++;

                result = 2f + 1f / previousNumber;

                previousNumber = result;
            }

            return (index, previousNumber, result);
        }
        private (int index, float previousNumber, float number) While29(float epsilon)
        {
            float firstPreviousNumber = 2;
            float secondPreviousNumber = 1;
            float result = 0;

            int index = 0;

            while (MathF.Abs(firstPreviousNumber - result) < epsilon)
            {
                index++;

                result = (secondPreviousNumber + 2f * firstPreviousNumber) / 3f;

                secondPreviousNumber = firstPreviousNumber;
                firstPreviousNumber = result;
            }

            return (index, firstPreviousNumber, result);
        }

        private int While30(int A, int B, int C)
        {
            float BSide;

            int K = 0;

            while ((A - C) >= 0)
            {
                A -= C;

                BSide = B;

                while (BSide - C >= 0)
                {
                    BSide -= C;

                    K++;
                }
            }

            return K;
        }
        #endregion

        #region Series

        private float Series1(List<float> numbers)
        {
            float summ = 0f;

            foreach (float number in numbers)
                summ += number;

            return summ;
        }

        private float Series2(List<float> numbers)
        {
            float mult = 1f;

            foreach (float number in numbers)
                mult *= number;

            return mult;
        }

        private float Series3(List<float> numbers)
        {
            float summ = 0f;

            foreach (float number in numbers)
                summ += number;

            return summ / numbers.Count;
        }

        private (float summ, float mult) Series4(int N)
        {
            var numbers = SeriesUtilities.CreateRandomFloatList(N);

            float summ = 0f;
            float mult = 1f;

            foreach (var number in numbers)
            {
                summ += number;
                mult *= number;
            }

            return (summ, mult);
        }

        private (List<float> numbers, float summ) Series5(int N)
        {
            var numbers = SeriesUtilities.CreateRandomFloatList(N);

            float summ = 0f;

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = (float)numbers[i] / 1;

                summ += numbers[i];
            }

            return (numbers, summ);
        }

        private (List<float> numbers, float mult) Series6(int N)
        {
            var numbers = SeriesUtilities.CreateRandomFloatList(N);

            float mult = 1f;

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = (float)numbers[i] % 1;

                mult *= numbers[i];
            }

            return (numbers, mult);
        }

        private (List<int> numbers, int summ) Series7(int N)
        {
            var numbers = SeriesUtilities.CreateRandomFloatList(N);

            List<int> roundNumbers = new();

            int summ = 0;

            foreach (var number in numbers)
            {
                var roundNumber = (int)MathF.Round(number);

                summ += roundNumber;

                roundNumbers.Add(roundNumber);
            }

            return (roundNumbers, summ);
        }

        private (List<int> numbers, int countOfOddNumbers) Series8(int N)
        {
            var numbers = SeriesUtilities.CreateRandomIntList(N);

            List<int> oddNumbers = new();

            int countOfOddNumbers = 0;

            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                    continue;

                countOfOddNumbers++;

                oddNumbers.Add(number);
            }

            return (oddNumbers, countOfOddNumbers);
        }

        private (List<int> indexes, int countOfNotOddNumbers) Series9(int N)
        {
            var numbers = SeriesUtilities.CreateRandomIntList(N);

            List<int> notOddNumbersIndexes = new();

            int countOfNotOddNumbers = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                    continue;

                countOfNotOddNumbers++;

                notOddNumbersIndexes.Add(i);
            }

            return (notOddNumbersIndexes, countOfNotOddNumbers);
        }

        private bool Series10(int N)
        {
            var numbers = SeriesUtilities.CreateRandomIntList(N);

            foreach (var number in numbers)
                if (number > 0)
                    return true;

            return false;
        }

        private bool Series11(int N, int K)
        {
            var numbers = SeriesUtilities.CreateRandomIntList(N);

            foreach (var number in numbers)
                if (number < K)
                    return true;

            return false;
        }

        private int Series12()
            => SeriesUtilities.CreateListEndingWithZero().Count;

        private int Series13()
        {
            var numbers = SeriesUtilities.CreateListEndingWithZero();

            int summ = 0;

            foreach (var number in numbers)
            {
                if (number < 0)
                    continue;

                summ += number;
            }

            return summ;
        }

        private int Series14(int K)
        {
            var numbers = SeriesUtilities.CreateListEndingWithZero();

            int countOfNumbersLessThanK = 0;

            foreach (var number in numbers)
            {
                if (number >= K)
                    continue;

                countOfNumbersLessThanK++;
            }

            return countOfNumbersLessThanK;
        }

        private int Series15(int K)
        {
            var numbers = SeriesUtilities.CreateListEndingWithZero();

            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] > K)
                    return i;

            return 0;
        }

        private int Series16(int K)
        {
            var numbers = SeriesUtilities.CreateListEndingWithZero();

            int lastNumberIndexLessThanK = 0;

            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] > K)
                    lastNumberIndexLessThanK = i;

            return lastNumberIndexLessThanK;
        }

        private List<float> Series17(float B, int N)
        {
            var numbers = SeriesUtilities.CreateRandomFloatList(N);

            numbers.Sort();

            if (B >= numbers[numbers.Count - 1])
            {
                numbers.Add(B);
            }
            else
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] >= B && B <= numbers[i + 1])
                    {
                        numbers.Insert(i, B);
                        break;
                    }
                }
            }

            return numbers;
        }

        private List<int> Series18(int N)
        {
            var numbers = SeriesUtilities.CreateRandomIntList(N);

            numbers.Sort();

            List<int> uniqueNumbers = new();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] != numbers[i + 1])
                    uniqueNumbers.Add(numbers[i]);
            }

            return uniqueNumbers;
        }

        private (List<int> lowerElements, int K) Series19(int N)
        {
            var numbers = SeriesUtilities.CreateRandomIntList(N);

            int countOfLowerElements = 0;

            List<int> lowerElements = new();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    countOfLowerElements++;

                    lowerElements.Add(numbers[i]);
                }
            }

            return (lowerElements, countOfLowerElements);
        }

        private (List<int> lowerElements, int K) Series20(int N)
        {
            var numbers = SeriesUtilities.CreateRandomIntList(N);

            int countOfLowerElements = 0;

            List<int> lowerElements = new();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    countOfLowerElements++;

                    lowerElements.Add(numbers[i]);
                }
            }

            return (lowerElements, countOfLowerElements);
        }

        private bool Series21(int N)
        {
            var numbers = SeriesUtilities.CreateRandomFloatList(N);

            for (int i = 1; i < numbers.Count; i++)
                if (numbers[i - 1] <= numbers[i])
                    return false;

            return true;
        }

        private int Series22(int N)
        {
            var numbers = SeriesUtilities.CreateRandomFloatList(N);

            for (int i = 1; i < numbers.Count; i++)
                if (numbers[i - 1] >= numbers[i])
                    return i;

            return 0;
        }

        private int Series23(int N)
        {
            var numbers = SeriesUtilities.CreateRandomFloatList(N);

            for (int i = 1; i < numbers.Count - 1; i++)
                if (!IsSawtooth(numbers[i - 1], numbers[i], numbers[i + 1]))
                    return i;

            return 0;
        }

        private bool IsSawtooth(float previousElement, float currentElement, float nextElement)
        {
            bool isLower = previousElement > currentElement && currentElement < nextElement;

            bool isHigher = previousElement < currentElement && currentElement > nextElement;

            return isLower || isHigher;
        }

        private int Series24(int N)
        {
            var numbers = SeriesUtilities.CreateRandomIntList(N);

            int summ = 0;
            int tempSumm = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i != 0)
                    continue;

                tempSumm += numbers[i];

                if (numbers[i] == 0)
                {
                    summ = tempSumm;
                    tempSumm = 0;
                }
            }

            return summ;
        }

        private int Series25(int N)
        {
            var numbers = SeriesUtilities.CreateRandomIntList(N);

            int? firstZeroIndex = null;
            int? secondZeroIndex = null;

            int summ = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i != 0)
                    continue;

                if (firstZeroIndex == null)
                    firstZeroIndex = i;
                else
                    secondZeroIndex = i;
            }

            for (int i = (int)firstZeroIndex; i < secondZeroIndex; i++)
                summ += numbers[i];

            return summ;

        }

        private void Series26(int N, int K)
        {
            var numbers = SeriesUtilities.CreateRandomFloatList(N);

            for(int i = 0; i < numbers.Count; i++)
                Console.WriteLine(For15(numbers[i], K));
        }

        private void Series27(int N)
        {
            var numbers = SeriesUtilities.CreateRandomFloatList(N);

            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(For15(numbers[i],  i + 1));
        }

        private void Series28(int N)
        {
            var numbers = SeriesUtilities.CreateRandomFloatList(N);

            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(For15(numbers[i], numbers.Count - i));
        }

        private int Series29(int N, int K)
        {
            var lists = SeriesUtilities.CreateIntListOfLists(K, N);

            int summ = 0;

            foreach(var list in lists)
                foreach(var number in list)
                    summ += number;

            return summ;
        }

        private void Series30(int N, int K)
        {
            var lists = SeriesUtilities.CreateIntListOfLists(K, N);

            int summ = 0;

            foreach (var list in lists)
            {
                foreach (var number in list)
                    summ += number;

                Console.WriteLine(summ);

                summ = 0;
            }
        }

        private int Series31(int N, int K)
        {
            var lists = SeriesUtilities.CreateIntListOfLists(K, N);

            int countOfListsWithTwo = 0;

            foreach (var list in lists)
            {
                foreach (var number in list)
                {
                    if (number == 2)
                    {
                        countOfListsWithTwo++;
                        break;
                    }
                }
            }

            return countOfListsWithTwo;
        }

        private void Series32(int N, int K) 
        {
            var lists = SeriesUtilities.CreateIntListOfLists(K, N);

            int indexOfFirstTwo = 0;

            foreach(var list in lists)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    if (list[i] == 2) 
                    { 
                        indexOfFirstTwo = i; 
                        break;
                    }
                }

                Console.WriteLine(indexOfFirstTwo);

                indexOfFirstTwo = 0;
            }
        }

        private void Series33(int N, int K)
        {
            var lists = SeriesUtilities.CreateIntListOfLists(K, N);

            int indexOfFirstTwo = 0;

            foreach (var list in lists)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == 2)
                        indexOfFirstTwo = i;
                }

                Console.WriteLine(indexOfFirstTwo);

                indexOfFirstTwo = 0;
            }
        }

        private void Series34(int N, int K)
        {
            var lists = SeriesUtilities.CreateIntListOfLists(K, N);

            bool hasTwo = false;

            int summ = 0;

            foreach (var list in lists)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == 2)
                    {
                        hasTwo = true;
                        break;
                    }

                    summ += list[i];
                }

                if (!hasTwo) 
                {
                    summ = 0;
                }

                Console.WriteLine(summ);
            }
        }

        private void Series35(int K)
        {
            var lists = SeriesUtilities.CreateIntListOfLists(K, 0, true, 1, 100);

            int summLength = 0;

            foreach(var list in lists)
            {
                Console.WriteLine(list.Count);

                summLength += list.Count;
            }
        }

        private int Series36(int K) 
        {
            var lists = SeriesUtilities.CreateIntListOfLists(K, 0, true, 1, 100);

            int countOfUprisingLists = 0;

            foreach(var list in lists)
            {
                countOfUprisingLists++;

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i - 1] <= list[i])
                    {
                        countOfUprisingLists--;
                        break;
                    }
                }
            }

            return countOfUprisingLists;
        }

        private int Series37(int K)
        {
            var lists = SeriesUtilities.CreateIntListOfLists(K, 0, true, 1, 100);

            bool isUprising = true;
            bool isFalling = true;

            int countOfUprisingOrFallingLists = 0;

            foreach (var list in lists)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i] < list[i - 1])
                        isUprising = false;
                    if(list[i] > list[i - 1])
                        isFalling = false;
                }

                if (isFalling != isUprising)
                    countOfUprisingOrFallingLists++;

                isFalling = true;
                isUprising = true;
            }

            return countOfUprisingOrFallingLists;
        }

        private void Series38(int K)
        {

            var list1 = new List<int>() { 1, 2, 3, 4 };

            var lists = new List<List<int>>() { list1 };

            bool isUprising = true;
            bool isFalling = true;

            foreach (var list in lists)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i] < list[i - 1])
                        isUprising = false;
                    if (list[i] > list[i - 1])
                        isFalling = false;
                }

                if (isFalling && isUprising)
                    Console.WriteLine(0);
                else if (isFalling && !isUprising)
                    Console.WriteLine(-1);
                else if (isUprising && !isFalling)
                    Console.WriteLine(1);

                isFalling = true;
                isUprising = true;
            }
        }

        private int Series39(int K)
        {
            var lists = SeriesUtilities.CreateIntListOfLists(K, 0, true, 1, 100);

            int countOfSawtoothLists = 0;

            foreach (var list in lists)
            {
                countOfSawtoothLists++;

                for(int i = 1; i < list.Count - 1; i++)
                {
                    if (!IsSawtooth(list[i - 1], list[i], list[i + 1]))
                    {
                        countOfSawtoothLists--;
                        break;
                    }
                }
            }

            return countOfSawtoothLists;
        }

        private void Series40(int K)
        {
            var lists = SeriesUtilities.CreateIntListOfLists(K, 0, true, 1, 100);

            int countOfSawtoothLists = 0;

            bool isSawtooth = true;

            foreach (var list in lists)
            {
                countOfSawtoothLists++;

                for (int i = 1; i < list.Count - 1; i++)
                {
                    if (!IsSawtooth(list[i - 1], list[i], list[i + 1]))
                    {
                        Console.WriteLine(list[i]);

                        isSawtooth = false;

                        break;
                    }
                }

                if (isSawtooth)
                    Console.WriteLine(list.Count);

                isSawtooth = true;
            }
        }
        #endregion
    }
}