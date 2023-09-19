
namespace Abramyan_Rush
{
    public class TasksPart2
    {
        public void RunTest()
        {
            For40(2, 10);
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
    }
}
