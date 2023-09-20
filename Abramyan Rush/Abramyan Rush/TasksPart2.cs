
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace Abramyan_Rush
{
    public class TasksPart2
    {
        public void RunTest()
        {

        }

        #region For

        private void For1(int N, int K)
        {
            for(int i = 0; i < N; i++)
                Console.WriteLine(K);
        }

        private void For2(int A, int B) 
        { 
            for(int i = A; i <= B; i++)
                Console.WriteLine(i);
        }

        private void For3(int A, int B)
        {
            for(int i = B - 1; i > A; i--)
                Console.WriteLine(i);

            Console.WriteLine(B - A - 1);
        }

        private void For4(float price)
        {
            for(int i = 1; i <= 10; i++)
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

            for(int i = A; i <= B; i++)
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

            for(int i = 0; i <= N; i++)
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

            for(int i = 0; i < N; i++)
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

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine(squareNumber);

                squareNumber *= A;
            }
        }

        private float For17(float A, int N)
        {
            float squareNumber = A;
            float summ = 1f;

            for(int i = 0; i < N; i++)
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

            for (int i = 1; i <= N; i+= 2)
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

            for(int i = 1; i <= N; i++)
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

            for(int i = 1; i <= N; i++)
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

            for(int i = 0; i < N; i++)
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

            for(int i = 2; i <= N; i++)
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

            for(int i = 1; i <= N; i++)
            {
                powerNumber = i;

                for(int j = 0; j < K; j++)
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

            for(int i = 0; i < N; i++)
            {
                powerNumber = i;

                for(int j = 0; j < i; j++)
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
            for(int i = A; i < B; i++)
            {
                for(int j = 0; j < i; j++)
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

            while(N >= 2)
            {
                N /= 2;

                K++;
            }

            return K;
        }

        private float While6(int N)
        {
            float factorial = 1f;

            while(N >= 2)
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

            while(N / squareNumber > N)
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

            while(squareNumber <= N)
            {
                K++;

                squareNumber *= 3;
            }

            return K;
        }

        private int While10(int N)
        {
            int squareNumber = 3;

            int K = 0;

            while (squareNumber < N)
            {
                K++;

                squareNumber *= 3;
            }

            return K;
        }

        private int While11(int N)
        {
            int K = 0;
            int summ = 0;

            while(summ <= N)
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

            while (summ + K + 1 !<= N)
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

            while(summ <= A)
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

            while(S <= 1100)
            {
                K++;

                S+= (S * P) / 100f;
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
            while(N > 0)
            {
                Console.WriteLine(N % 10);

                N /= 10;
            }
        }

        private (int countOfNumbers, int summOfNumbers) While18(int N)
        {
            int summ = 0;
            int counter = 0;

            while(N > 0)
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

            while(N > 0)
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

            while(N > 0)
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
            while(A != 0 && B != 0)
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

                if(result == N)
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

            while(MathF.Abs(previousNumber - result) < epsilon)
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

                while(BSide - C >= 0)
                {
                    BSide -= C;

                    K++;
                }
            }

            return K;
        }
    }
    #endregion
}
