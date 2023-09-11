
namespace Abramyan_Rush
{
    public class ScriptsPart1
    {
        public void RunTest()
        {

        }

        #region Begin
        private float Begin1(float sideSize)
            => 4f * sideSize;

        private float Begin2(float sideSize)
            => sideSize * sideSize;

        private float Begin3(float sideOneSize, float sideTwoSize)
            => sideOneSize * sideTwoSize;

        private float Begin4(float diameter)
            => diameter * MathF.PI;

        private (float square, float size) Begin5(float sideSize)
        {
            float cubeSize = sideSize * sideSize * sideSize;

            float cubeSurfaceSquare = sideSize * 6f;

            return (cubeSize, cubeSurfaceSquare);
        }

        private (float square, float size) Begin6(float sideOneSize, float sideTwoSize, float sideThreeSize)
        {
            float cubeSize = sideOneSize * sideTwoSize * sideThreeSize;

            float cubeSurfaceSquare = 2f * (sideOneSize * sideTwoSize + sideTwoSize * sideThreeSize + sideOneSize * sideThreeSize);

            return (cubeSize, cubeSurfaceSquare);
        }

        private (float length, float square) Begin7(float radius)
        {
            float circleLength = 2f * MathF.PI * radius;

            float circleSquare = MathF.PI * (radius * radius);

            return (circleLength, circleSquare);
        }

        private float Begin8(float numberOne, float numberTwo)
            => (numberOne + numberTwo) / 2f;

        private float Begin9(float numberOne, float numberTwo)
            => MathF.Sqrt(numberOne * numberTwo);

        private (float summ, float difference, float mult, float div) Begin10(float numberOne, float numberTwo)
        {
            float numberOneSquare = numberOne * numberOne;
            float numberTwoSquare = numberTwo * numberTwo;

            float summ = numberOneSquare + numberTwoSquare;

            float difference = numberOneSquare - numberTwoSquare;

            float mult = numberOneSquare * numberTwoSquare;

            float div = numberOneSquare / numberTwoSquare;

            return (summ, difference, mult, div);
        }

        private (float summ, float difference, float mult, float div) Begin11(float numberOne, float numberTwo)
        {
            float numberOneModule = MathF.Abs(numberOne);
            float numberTwoModule = MathF.Abs(numberTwo);

            float summ = numberOneModule + numberTwoModule;

            float difference = numberOneModule - numberTwoModule;

            float mult = numberOneModule * numberTwoModule;

            float div = numberOneModule / numberTwoModule;

            return (summ, difference, mult, div);
        }

        private (float hypotenuse, float perimeter) Begin12(float sideOne, float sideTwo)
        {
            float hypotenuse = MathF.Sqrt(sideOne * sideOne + sideTwo * sideTwo);

            float perimeter = sideOne + sideTwo + hypotenuse;

            return (hypotenuse, perimeter);
        }

        private (float squareOne, float squareTwo, float squareThree) Begin13(float radiusOne, float radiusTwo)
        {
            float squareOne = MathF.PI * radiusOne * radiusOne;

            float squareTwo = MathF.PI * radiusTwo * radiusTwo;

            float squareThree = squareOne - squareTwo;

            return (squareOne, squareTwo, squareThree);
        }

        private (float radius, float square) Begin14(float length)
        {
            float radius = length / 2f * MathF.PI;

            float square = MathF.PI * radius * radius;

            return (radius, square);
        }

        private (float diameter, float length) Begin15(float square)
        {
            float radius = MathF.Sqrt(square / MathF.PI);

            float length = 2f * MathF.PI * radius;

            return (radius * 2f, length);
        }

        private float Begin16(float x1, float x2)
            => MathF.Abs(x2 - x1);

        private (float lengthOne, float lengthTwo, float lengthSumm) Begin17(float pointOne, float pointTwo, float pointThree)
        {
            float lengthOne = MathF.Abs(pointThree - pointOne);

            float lengthTwo = MathF.Abs(pointThree - pointTwo);

            return (lengthOne, lengthTwo, lengthOne + lengthTwo);
        }

        private float Begin18(float pointOne, float pointTwo, float pointCenter)
        {
            float lengthOne = MathF.Abs(pointCenter - pointOne);

            float lengthTwo = MathF.Abs(pointCenter - pointTwo);

            return lengthOne - lengthTwo;
        }

        private (float perimeter, float square) Begin19((float x, float y) cordsOne, (float x, float y) cordsTwo)
        {
            (float x, float y) cordsThree = (cordsOne.x, cordsTwo.y);
            (float x, float y) cordsFour = (cordsTwo.x, cordsOne.y);

            float lengthOne = MathF.Abs(cordsThree.x - cordsTwo.x);
            float lengthTwo = MathF.Abs(cordsFour.y - cordsTwo.y);

            float perimeter = 2f * (lengthOne + lengthTwo);
            float square = lengthOne * lengthTwo;

            return (perimeter, square);
        }

        private float Begin20((float x, float y) cordsOne, (float x, float y) cordsTwo)
        {
            float differenceOne = cordsTwo.x - cordsOne.x;
            float differenceTwo = cordsTwo.y - cordsOne.y;

            return MathF.Sqrt(differenceOne * differenceOne + differenceTwo * differenceTwo);
        }

        private (float perimeter, float square) Begin21((float x, float y) cordsOne, (float x, float y) cordsTwo, (float x, float y) cordsThree)
        {
            float differenceOneTwoX = cordsTwo.x - cordsOne.x;
            float differenceOneTwoY = cordsTwo.y - cordsOne.y;

            float sideOne = MathF.Sqrt(differenceOneTwoX * differenceOneTwoX + differenceOneTwoY * differenceOneTwoY);

            float differenceTwoThreeX = cordsThree.x - cordsTwo.x;
            float differenceTwoThreeY = cordsThree.y - cordsThree.y;

            float sideTwo = MathF.Sqrt(differenceTwoThreeX * differenceTwoThreeX + differenceTwoThreeY * differenceTwoThreeY);

            float differenceThreeOneX = cordsOne.x - cordsThree.x;
            float differenceThreeOneY = cordsOne.y - cordsThree.y;

            float sideThree = MathF.Sqrt(differenceThreeOneX * differenceThreeOneX + differenceThreeOneY * differenceThreeOneY);

            float perimeter = sideThree + sideTwo + sideOne;

            float halfPerimeter = perimeter / 2f;

            float square = MathF.Sqrt(halfPerimeter * (halfPerimeter - sideOne) * (halfPerimeter - sideTwo) * (halfPerimeter - sideThree));

            return (perimeter, square);
        }

        private void Begin22(float numberOne, float numberTwo)
        {
            float temp = numberTwo;

            numberTwo = numberOne;

            numberOne = temp;

            Console.WriteLine(numberOne + " , " + numberTwo);
        }

        private void Begin23(float numberOne, float numberTwo, float numberThree)
        {
            float temp = numberThree;

            numberThree = numberTwo;

            numberTwo = numberOne;

            numberOne = temp;

            Console.WriteLine(numberOne + " , " + numberTwo + " , " + numberThree);
        }

        private void Begin24(float numberOne, float numberTwo, float numberThree)
        {
            float temp = numberOne;

            numberOne = numberTwo;

            numberTwo = numberThree;

            numberThree = temp;

            Console.WriteLine(numberOne + " , " + numberTwo + " , " + numberThree);
        }

        private float Begin25(float X)
            => 3f * MathF.Pow(X, 6) - 6 * X * X - 7;

        private float Begin26(float X)
        {
            float firstElement = 4f * MathF.Pow(X - 3f, 6);

            float secondElement = 7 * MathF.Pow(X - 3, 3);

            return firstElement - secondElement + 2f;
        }

        private void Begin27(float number)
        {
            float originNumber = number;

            for (int i = 2; i <= 8; i++)
            {
                number *= originNumber;

                Console.WriteLine(number);
            }
        }

        private void Begin28(float number)
        {
            float originNumber = number;

            for (int i = 2; i <= 15; i++)
            {
                number *= originNumber;

                Console.WriteLine(number);
            }
        }

        private float Begin29(float angleDegrees)
        {
            float angle = angleDegrees * MathF.PI;

            return angle / 180f;
        }

        private float Begin30(float angleRadians)
        {
            float angle = angleRadians * 180f;

            return angle / MathF.PI;
        }

        private float Begin31(float temperatureCelsius)
            => (temperatureCelsius - 32f) * 5f / 9f;

        private float Begin32(float temperatureCelsius)
            => temperatureCelsius * 5f / 9f + 32f;

        private (float OneKiloPrice, float YKiloPrice) Begin33(float firstMass, float secondMass, float XKiloPrice)
        {
            float price = firstMass / XKiloPrice;

            return (price, price * secondMass);
        }

        private (float chocolateOneKiloPrice, float toffeOneKiloPrice, float priceDifference) Begin34(float chocolateMass, float chocolatePrice, float toffeMass, float toffePrice)
        {
            float chocolateOneKiloPrice = chocolateMass / chocolatePrice;
            float toffeOneKiloPrice = toffeMass / toffePrice;

            float difference = chocolateOneKiloPrice / toffeOneKiloPrice;

            return (chocolateOneKiloPrice, toffeOneKiloPrice, difference);
        }

        private float Begin35(float boatSpeed, float streamSpeed, float firstTime, float secondTime)
        {
            float speedAgainstStream = boatSpeed - streamSpeed;

            float lakeDistance = boatSpeed * firstTime;
            float riverDistance = speedAgainstStream * secondTime;

            return lakeDistance + riverDistance;
        }

        private float Begin36(float firstCarSpeed, float secondCarSpeed, float time, float distanceBetweenCars)
        {
            float firstCarDistance = firstCarSpeed * time;
            float secondCarDistance = secondCarSpeed * time;

            return firstCarDistance + secondCarDistance + distanceBetweenCars;
        }

        private float Begin37(float firstCarSpeed, float secondCarSpeed, float time, float distanceBetweenCars)
        {
            float firstCarDistance = firstCarSpeed * time;
            float secondCarDistance = secondCarSpeed * time;

            return MathF.Abs(distanceBetweenCars - (firstCarDistance + secondCarDistance));
        }

        private bool Begin38(float firstNumber, float secondNumber, float X)
            => firstNumber * X == -secondNumber;

        private (float firstRoot, float secondRoot) Begin39(float firstElement, float secondElement, float ThirdElement)
        {
            float discriminant = secondElement * secondElement - 4f * firstElement * ThirdElement;

            float firstRoot = (-secondElement + MathF.Sqrt(discriminant)) / (2f * firstElement);
            float secondRoot = (-secondElement - MathF.Sqrt(discriminant)) / (2f * firstElement);

            return (firstRoot, secondRoot);
        }

        private (float firstRoot, float secondRoot) Begin40(float firstA, float firstB, float firstC, float secondA, float secondB, float secondC)
        {
            float D = firstA * secondB + secondA * firstA;

            float X = (firstC * secondB - secondC * firstB) / D;
            float Y = (firstA * secondC - secondA * firstC) / D;

            return (X, Y);
        }
        #endregion
    }
}