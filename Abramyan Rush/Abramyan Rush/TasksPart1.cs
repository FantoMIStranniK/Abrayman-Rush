﻿
namespace Abramyan_Rush
{
    public class TasksPart1
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

        #region Integer

        private int Integer1(int length)
            => length / 100;

        private int Integer2(int mass)
            => mass / 1000;

        private int Integer3(int byteSize)
            => byteSize / 1024;

        private int Integer4(int lengthOne, int lengthTwo)
            => lengthOne / lengthTwo;

        private int Integer5(int lengthOne, int lengthTwo)
            => lengthOne % lengthTwo;

        private (int tens, int ones) Integer6(int number)
        {
            int tens = number / 10;
            int ones = number % 10;

            return (tens, ones);
        }

        private (int summ, int mult) Integer7(int number)
        {
            int tens = number / 10;
            int ones = number % 10;

            return (tens + ones, tens * ones);
        }

        private int Integer8(int number)
        {
            int tens = number / 10;
            int ones = number % 10;

            int newNumber = ones * 10 + tens;

            return newNumber;
        }

        private int Integer9(int number)
            => number / 100;

        private (int ones, int tens) Integer10(int number)
        {
            int ones = number % 10;

            int tens = ((number % 100) - ones) / 10;

            return (ones, tens);
        }

        private (int hundreds, int tens, int ones) GetNumberElements(int number)
        {
            int ones = number % 10;

            int tens = ((number % 100) - ones) / 10;

            int hundreds = number / 100;

            return (hundreds, tens, ones);
        }

        private (int summ, int mult) Integer11(int number)
        {
            var numberBits = GetNumberElements(number);

            int summ = numberBits.hundreds + numberBits.ones + numberBits.tens;
            int mult = numberBits.hundreds * numberBits.ones * numberBits.tens;

            return (summ, mult);
        }

        private int Integer12(int number)
        {
            var numberBits = GetNumberElements(number);

            int newNumber = numberBits.ones * 100 + numberBits.tens * 10 + numberBits.hundreds;

            return newNumber;
        }

        private int Integer13(int number)
        {
            int cutNumber = number / 100;

            number = number % 100;

            number *= 10;

            number += cutNumber;

            return number;
        }

        private int Integer14(int number)
        {
            int cutNumber = number % 10;

            number = number / 10;

            cutNumber *= 100;

            number += cutNumber;

            return number;
        }

        private int Integer15(int number)
        {
            var numberBits = GetNumberElements(number);

            int newNumber = numberBits.ones + numberBits.hundreds * 10 + numberBits.tens * 100;

            return newNumber;
        }

        private int Integer16(int number)
        {
            var numberBits = GetNumberElements(number);

            number = numberBits.hundreds * 100 + numberBits.ones * 10 + numberBits.tens;

            return number;
        }

        private int Integer17(int number)
            => number % 1000 / 100;

        private int Integer18(int number)
            => number % 10000 / 1000;

        private int Integer19(int time)
            => time / 60;

        private int Integer20(int time)
            => time / 3600;

        private int Integer21(int time)
            => time % 60;

        private int Integer22(int time)
            => time % 3600;

        private int Integer23(int time)
        {
            int timeLeft = time % 3600;

            return timeLeft / 60;
        }

        private int Integer24(int day)
            => day % 7;

        private int Integer25(int day)
        {
            day = day % 7;

            int startDay = 3;

            if (day >= 4)
                startDay = 0;

            return day + startDay;
        }

        private int Integer26(int day)
        {
            day = day % 7;

            int startDay = 2;

            if (day >= 5)
                startDay = 0;

            return day + startDay;
        }

        private int Integer27(int day)
        {
            day = day % 7;

            int startDay = 6;

            if (day >= 1)
                startDay = 0;

            return day + startDay;
        }

        private int Integer28(int day, int startDayIndex)
        {
            day = day % 7;

            if (day >= 7 - startDayIndex)
                startDayIndex = 0;

            return day + startDayIndex;
        }

        private (int countOfSquares, float freeSquare) Integer29(int sideA, int sideB, int sideC)
        {
            int rectangleSquare = sideA * sideB;

            int quadrateSquare = sideC * sideC;

            int countOfSquares = rectangleSquare / quadrateSquare;

            float freeSquare = rectangleSquare % quadrateSquare;

            return (countOfSquares, freeSquare);
        }

        private int Integer30(int year)
        {
            if (year % 100 == 0)
                return year / 100;

            return (year - 1) / 100 + 1;
        }
        #endregion

        #region Boolean

        private bool Boolean1(int number)
            => number > 0;

        private bool Boolean2(int number)
            => number % 2 != 0;

        private bool Boolean3(int number)
            => number % 2 == 0;

        private bool Boolean4(int numberOne, int numberTwo)
            => numberOne > 2 && numberTwo <= 3;

        private bool Boolean5(int numberOne, int numberTwo)
            => numberOne >= 0 || numberTwo < -2;

        private bool Boolean6(int numberOne, int numberTwo, int numberThree)
            => numberOne < numberTwo && numberTwo < numberThree;

        private bool Boolean7(int numberOne, int numberTwo, int numberThree)
            => Boolean6(numberOne, numberTwo, numberThree) || Boolean6(numberThree, numberTwo, numberOne);

        private bool Boolean8(int numberOne, int numberTwo)
            => numberOne % 2 != 0 && numberTwo % 2 != 0;

        private bool Boolean9(int numberOne, int numberTwo)
            => numberOne % 2 != 0 || numberTwo % 2 != 0;

        private bool Boolean10(int numberOne, int numberTwo)
            => OneOfTwoNumbersIsNotOdd(numberOne, numberTwo) || OneOfTwoNumbersIsNotOdd(numberTwo, numberOne);
        private bool OneOfTwoNumbersIsNotOdd(int numberOne, int numberTwo)
            => numberOne % 2 != 0 && numberTwo % 2 == 0;

        private bool Boolean11(int numberOne, int numberTwo)
            => numberOne % 2 == numberTwo % 2;

        private bool Boolean12(int numberOne, int numberTwo, int numberThree)
            => numberOne > 0 && numberTwo > 0 && numberThree > 0;

        private bool Boolean13(int numberOne, int numberTwo, int numberThree)
            => numberOne > 0 || numberTwo > 0 || numberThree > 0;

        private bool Boolean14(int numberOne, int numberTwo, int numberThree)
            => Convert.ToInt32(numberOne > 0) + Convert.ToInt32(numberTwo > 0) + Convert.ToInt32(numberThree > 0) == 1;

        private bool Boolean15(int numberOne, int numberTwo, int numberThree)
            => Convert.ToInt32(numberOne > 0) + Convert.ToInt32(numberTwo > 0) + Convert.ToInt32(numberThree > 0) == 2;

        private bool Boolean16(int number)
            => number / 10 < 10 && number % 2 == 0;

        private bool Boolean17(int number)
            => number / 10 > 10 && number % 2 != 0;

        private bool Boolean18(int numberOne, int numberTwo, int numberThree)
            => numberOne == numberTwo || numberTwo == numberThree || numberOne == numberThree;

        private bool Boolean19(int numberOne, int numberTwo, int numberThree)
            => numberOne == -numberTwo || numberTwo == -numberThree || numberOne == -numberThree;

        private bool Boolean20(int number)
        {
            (int ones, int tens, int hundreds) numberBits = GetNumberElements(number);

            return numberBits.ones != numberBits.tens &&
                numberBits.ones != numberBits.hundreds &&
                numberBits.hundreds != numberBits.tens;
        }

        private bool IsUprising(List<int> numbers)
        {
            int previousNumber = int.MinValue;

            foreach (var number in numbers)
            {
                if (number <= previousNumber)
                    return false;
                else
                    previousNumber = number;
            }

            return true;
        }

        private bool Boolean21(int number)
        {
            (int hundreds, int tens, int ones) numberBits = GetNumberElements(number);

            return IsUprising(new List<int>() { numberBits.hundreds, numberBits.tens, numberBits.ones });
        }

        private bool Boolean22(int number)
        {
            (int hundreds, int tens, int ones) numberBits = GetNumberElements(number);

            return IsUprising(new List<int>() { numberBits.hundreds, numberBits.tens, numberBits.ones }) || IsUprising(new List<int>() { numberBits.ones, numberBits.tens, numberBits.hundreds });
        }

        private bool Boolean23(int number)
        {
            int thousands = number / 1000;

            int hundreds = (number / 100) - thousands * 10;

            int tens = (number / 10) - (thousands * 100 + hundreds * 10);

            int ones = number % 10;

            return thousands == ones && hundreds == tens;
        }

        private bool Boolean24(int numberOne, int numberTwo, int numberThree)
        {
            int discriminant = numberThree * numberTwo - 4 * numberOne * numberThree;

            return discriminant >= 0;
        }

        private bool Boolena25((int x, int y) cords)
            => cords.x < 0 && cords.y > 0;

        private bool Boolean26((int x, int y) cords)
            => cords.x > 0 && cords.y < 0;

        private bool Boolean27((int x, int y) cords)
            => cords.x < 0 && cords.y != 0;

        private bool Boolean28((int x, int y) cords)
            => (cords.x / MathF.Abs(cords.x)) == (cords.y / MathF.Abs(cords.y));

        private bool Boolean29((int x, int y) cords, (int x, int y) leftTopCord, (int x, int y) rightLowerCord)
            => cords.x > leftTopCord.x && cords.x < rightLowerCord.x && cords.y < leftTopCord.y && cords.y > rightLowerCord.y;

        private bool Boolean30(int sideOne, int sideTwo, int sideThree)
            => sideOne == sideTwo && sideTwo == sideThree && sideOne == sideThree;

        private bool Boolean31(int sideOne, int sideTwo, int sideThree)
            => SidesAreEqual(sideOne, sideTwo, sideThree) || SidesAreEqual(sideThree, sideOne, sideTwo) || SidesAreEqual(sideTwo, sideThree, sideOne);

        private bool SidesAreEqual(int equalSideOne, int equalSideTwo, int baseSide)
            => equalSideOne == equalSideTwo && equalSideOne != baseSide && equalSideTwo != baseSide;

        private bool Boolean32(int sideOne, int sideTwo, int sideThree)
            => IsHypotynuse(sideOne, sideTwo, sideThree) || IsHypotynuse(sideThree, sideOne, sideTwo) || IsHypotynuse(sideTwo, sideThree, sideOne);

        private bool IsHypotynuse(int sideOne, int sideTwo, int hypotynuse)
            => hypotynuse * hypotynuse == sideOne * sideOne + sideTwo * sideTwo;

        private bool Boolean33(int sideOne, int sideTwo, int sideThree)
            => IsExistingTriangle(sideOne, sideTwo, sideThree) || IsExistingTriangle(sideThree, sideOne, sideTwo) || IsExistingTriangle(sideTwo, sideThree, sideOne);
        private bool IsExistingTriangle(int sideOne, int sideTwo, int sideThree)
            => sideThree < sideOne + sideTwo;

        private bool Boolean34((int x, int y) cords)
            => (cords.x + cords.y) % 2 != 0;

        private bool Boolean35((int x, int y) cordsOne, (int x, int y) cordsTwo)
            => Boolean34(cordsOne) == Boolean34(cordsTwo);

        private bool Boolean36((int x, int y) cordsOne, (int x, int y) cordsTwo)
        {
            if (cordsOne == cordsTwo)
                return false;

            bool canGoUp = (cordsOne.x == cordsTwo.x) && (cordsOne.y != cordsTwo.y);
            bool canGoSideways = (cordsOne.y == cordsTwo.y) && (cordsOne.x != cordsTwo.y);

            return canGoSideways || canGoUp;
        }

        private bool Boolean37((int x, int y) cordsOne, (int x, int y) cordsTwo)
        {
            if (cordsOne == cordsTwo)
                return false;

            bool canGoToX = MathF.Abs(cordsOne.x - cordsTwo.x) <= 1;
            bool canGoToY = MathF.Abs(cordsOne.y - cordsTwo.y) <= 1;

            return canGoToX && canGoToY;
        }

        private bool Boolean38((int x, int y) cordsOne, (int x, int y) cordsTwo)
        {
            if (cordsOne == cordsTwo)
                return false;

            bool canGo = MathF.Abs(cordsOne.x - cordsTwo.x) == MathF.Abs(cordsOne.y - cordsTwo.y);

            return canGo;
        }

        private bool Boolean39((int x, int y) cordsOne, (int x, int y) cordsTwo)
            => Boolean36(cordsOne, cordsTwo) || Boolean38(cordsOne, cordsTwo);

        private bool Boolean40((int x, int y) cordsOne, (int x, int y) cordsTwo)
        {
            if (cordsOne == cordsTwo)
                return false;

            bool canGoSide = MathF.Abs(cordsOne.x - cordsTwo.x) == 1 && MathF.Abs(cordsOne.y - cordsTwo.y) == 2;
            bool canGoUp = MathF.Abs(cordsOne.y - cordsTwo.y) == 1 && MathF.Abs(cordsOne.x - cordsTwo.x) == 2;

            return canGoSide && canGoUp;
        }
        #endregion


        private int If1(int number)
            => number > 0 ? number + 1 : number;

        private int If2(int number)
            => number > 0 ? number + 1 : number - 2;

        private int If3(int number)
        {
            if (number > 0)
                number += 1;
            else if (number < 0)
                number -= 2;
            else
                number = 10;

            return number;
        }

        private int If4(int numberOne, int numberTwo, int numberThree)
        {
            List<int> numbers = new() { numberOne, numberTwo, numberThree };

            int countOfPositiveNumbers = 0;

            foreach (var number in numbers)
            {
                if (number > 0)
                    countOfPositiveNumbers++;
            }

            return countOfPositiveNumbers;
        }

        private (int positiveNumbers, int negativeNumbers) If5(int numberOne, int numberTwo, int numberThree)
        {
            List<int> numbers = new() { numberOne, numberTwo, numberThree };

            int countOfPositiveNumbers = 0;
            int countOfNegativeNumbers = 0;

            foreach (var number in numbers)
            {
                if (number > 0)
                    countOfPositiveNumbers++;
                else if (number < 0)
                    countOfNegativeNumbers++;
            }

            return (countOfPositiveNumbers, countOfNegativeNumbers);
        }

        private int If6(int numberOne, int numberTwo)
            => numberOne > numberTwo ? numberOne : numberTwo;

        private int If7(int numberOne, int numberTwo)
            => numberOne < numberTwo ? 1 : 2;

        private (int biggest, int smallest) If8(int numberOne, int numberTwo)
        {
            if (numberOne > numberTwo)
                return (numberOne, numberTwo);
            else
                return (numberTwo, numberOne);
        }

        private (float smallest, float biggest) If9(float numberOne, float numberTwo)
        {
            if (numberOne > numberTwo)
            {
                float temp = numberOne;

                numberOne = numberTwo;

                numberTwo = temp;
            }

            return (numberOne, numberTwo);
        }

        private (float first, float second) If10(float numberOne, float numberTwo)
        {
            if (numberOne == numberTwo)
            {
                return (0, 0);
            }

            float summ = numberOne + numberTwo;

            return (summ, summ);
        }

        private (float first, float second) If11(float numberOne, float numberTwo)
        {
            if (numberOne == numberTwo)
            {
                var sortedNumbers = If9(numberOne, numberTwo);

                numberOne = sortedNumbers.biggest;
                numberTwo = sortedNumbers.biggest;
            }
            else
            {
                float summ = numberOne + numberTwo;

                numberOne = summ;
                numberTwo = summ;
            }

            return (numberOne, numberTwo);
        }

        private float If12(int numberOne, int numberTwo, int numberThree)
        {
            float minValue = float.MaxValue;

            List<float> numbers = new() { numberOne, numberTwo, numberThree };

            foreach (var number in numbers)
            {
                if (number < minValue)
                    minValue = number;
            }

            return minValue;
        }

        private float If13(int numberOne, int numberTwo, int numberThree)
        {
            float minValue = If12(numberOne, numberTwo, numberThree);

            float maxValue = float.MinValue;

            List<float> numbers = new() { numberOne, numberTwo, numberThree };

            foreach (var number in numbers)
            {
                if (number > maxValue)
                    maxValue = number;
            }

            return numberOne + numberTwo + numberThree - minValue - maxValue;
        }

        private (float smallest, float biggest) If14(int numberOne, int numberTwo, int numberThree)
        {
            float minValue = If12(numberOne, numberTwo, numberThree);

            float mediumValue = If13(numberOne, numberTwo, numberThree);

            float maxValue = numberOne + numberTwo + numberThree - minValue - mediumValue;

            return (minValue, maxValue);
        }

        private float If15(int numberOne, int numberTwo, int numberThree)
        {
            if (numberOne <= numberTwo && numberOne <= numberThree)
                return numberTwo + numberThree;
            else if (numberTwo <= numberOne && numberTwo <= numberThree)
                return numberTwo + numberOne;
            else
                return numberOne + numberThree;
        }

        private (float numberOne, float numberTwo, float numberThree) If16(int numberOne, int numberTwo, int numberThree)
        {
            List<float> numbers = new() { numberOne, numberTwo, numberThree };

            float previousNumber = float.MinValue;

            foreach (var number in numbers)
            {
                if (number >= previousNumber)
                    continue;

                return (-numberOne, -numberTwo, -numberThree);
            }

            return (numberOne * 2, numberTwo * 2, numberThree * 2);
        }

        private (float numberOne, float numberTwo, float numberThree) If17(int numberOne, int numberTwo, int numberThree)
        {
            if ((numberOne <= numberTwo && numberTwo <= numberThree) || (numberOne >= numberTwo && numberTwo >= numberThree))
                return (numberOne * 2, numberTwo * 2, numberThree * 2);
            else
                return (-numberOne, -numberTwo, -numberThree);
        }

        private int If18(int numberOne, int numberTwo, int numberThree)
        {
            if (numberOne == numberTwo)
                return 3;

            if (numberOne == numberThree)
                return 2;

            return 1;
        }

        private int If19(int numberOne, int numberTwo, int numberThree, int numberFour)
        {
            if (numberOne == numberTwo && numberOne == numberThree)
                return numberFour;

            if (numberTwo == numberThree && numberTwo == numberFour)
                return numberOne;

            if (numberThree == numberFour && numberThree == numberOne)
                return numberTwo;

            return numberThree;
        }

        private (char pointName, float distance) If20((float x, float y) pointA, (float x, float y) pointB, (float x, float y) pointC)
        {
            float distanceAB = MathF.Sqrt((pointA.x - pointB.x) * (pointA.x - pointB.x) + (pointA.y - pointB.y) * (pointA.y - pointB.y));

            float distanceAC = MathF.Sqrt((pointA.x - pointC.x) * (pointA.x - pointC.x) + (pointA.y - pointC.y) * (pointA.y - pointC.y));

            return distanceAB > distanceAC ? ('C', distanceAC) : ('B', distanceAB);
        }

        private int If21((float x, float y) point)
        {
            if (point.x == 0 && point.y == 0)
                return 0;

            if (point.x == 0 && point.y != 0)
                return 2;

            if (point.x != 0 && point.y == 0)
                return 1;

            return 3;
        }

        private int If22((float x, float y) point)
        {
            if (point.x > 0 && point.y > 0)
                return 1;

            if (point.x < 0 && point.y > 0)
                return 2;

            if (point.x < 0 && point.y < 0)
                return 3;

            if (point.x > 0 && point.y < 0)
                return 4;

            return 0;
        }

        private (float x, float y) If23((float x, float y) pointOne, (float x, float y) pointTwo, (float x, float y) pointThree)
        {
            float y = 0;

            if (pointOne.y == pointTwo.y)
                y = pointThree.y;
            else if (pointOne.y == pointThree.y)
                y = pointTwo.y;

            float x = 0;

            if (pointOne.x == pointTwo.x)
                x = pointThree.x;
            else if (pointOne.x == pointThree.x)
                x = pointTwo.x;

            return (x, y);
        }

        private float If24(float X)
        {
            if (X > 0)
                return 2f * MathF.Sin(X);

            return 6f - X;
        }

        private int If25(int X)
        {
            if (X < -2 || X > 2)
                return 2 * X;

            return -3 * X;
        }

        private float If26(float X)
        {
            if (X <= 0)
                return -X;

            if (X >= 2)
                return 4;

            return X * X;
        }

        private int If27(float X)
        {
            if (X < 0)
                return 0;

            X = MathF.Floor(X);

            if (X % 2 == 0)
                return 1;

            return -1;
        }

        private int If28(int year)
        {
            bool canBeDividedByFour = year % 4 == 0;
            bool cantBeDividedByHundred = year % 100 != 0;
            bool canBeDividedByFourHundred = year % 400 == 0;

            if (canBeDividedByFour && (cantBeDividedByHundred || canBeDividedByFourHundred))
                return 366;
            else
                return 365;
        }

        private string If29(int number)
        {
            if (number == 0)
                return "нулевое число";

            string result = "";

            if (number % 2 == 0)
                result += "четное";
            else
                result += "нечетное";

            if (number > 0)
                result += " положительное";
            else
                result += " отрицательное";

            return result + " число";
        }
        private string If30(int number)
        {
            string result = "";

            if (number % 2 == 0)
                result += "четное";
            else
                result += "нечетное";

            if (number / 100 > 0)
                result += " трехзначное";
            else if (number / 10 > 0)
                result += " двузначное";
            else
                result += " однозначное";

            return result + " число";
        }

        //#endregion

        #region Case

        private string Case1(int dayNumber)
            => dayNumber switch
            {
                1 => "понедельник",
                2 => "вторник",
                3 => "середа",
                4 => "четверг",
                5 => "пятница",
                6 => "суббота",
                7 => "воскресенье",
                _ => "ошибка"
            };

        private string Case2(int mark)
            => mark switch
            {
                1 => "плохо",
                2 => "неудовлетворительно",
                3 => "удовлетворительно",
                4 => "хорошо",
                5 => "отлично",
                _ => "ошибка"
            };

        private string Case3(int monthNumber)
        {
            string month = monthNumber switch
            {
                1 or 2 or 12 => "зима",
                3 or 4 or 5 => "весна",
                6 or 7 or 8 => "лето",
                9 or 10 or 11 => "осень",
            };

            return month;
        }

        private int Case4(int monthNumber)
        {
            int countOfDays = monthNumber switch
            {
                1 or 3 or 5 or 6 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28
            };

            return countOfDays;
        }

        private float Case5(int operationIndex, float numberOne, float numberTwo)
        {
            float result = operationIndex switch
            {
                1 => numberOne + numberTwo,
                2 => numberOne - numberTwo,
                3 => numberOne * numberTwo,
                4 => numberOne / numberTwo,
            };

            return result;
        }

        private float Case6(int lengthMeasureIndex, float length)
        {
            float lengthModifier = lengthMeasureIndex switch
            {
                1 => 0.1f,
                2 => 10f,
                3 => 1f,
                4 => 0.001f,
                5 => 0.01f
            };

            return lengthModifier * length;
        }

        private float Case7(int weightMeasureIndex, float weight)
        {
            float weightModifier = weightMeasureIndex switch
            {
                1 => 1f,
                2 => 0.000001f,
                3 => 0.001f,
                4 => 1000f,
                5 => 100f
            };

            return weightModifier * weight;
        }

        private (int dayNumber, int monthNumber) Case8(int dayNumber, int monthNumber)
        {
            dayNumber++;

            int dayLimit = monthNumber switch
            {
                1 or 3 or 5 or 6 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28
            };

            if (dayNumber > dayLimit)
            {
                dayNumber = 1;
                monthNumber++;
            }

            if (monthNumber > 12)
                monthNumber = 1;

            return (dayNumber, monthNumber);
        }

        private (int dayNumber, int monthNumber) Case9(int dayNumber, int monthNumber)
        {
            dayNumber--;

            if (dayNumber > 0)
                return (dayNumber, monthNumber);

            monthNumber--;

            if (monthNumber <= 0)
                monthNumber = 12;

            dayNumber = monthNumber switch
            {
                1 or 3 or 5 or 6 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28
            };

            return (dayNumber, monthNumber);
        }

        private char Case10(char direction, int command)
        {
            int directionIndex = DecodeDirection(direction);

            directionIndex += command;

            if (directionIndex > 4)
                directionIndex = 1;
            else if (directionIndex < 0)
                directionIndex = 4;

            return EncodeDirection(directionIndex);
        }

        private int DecodeDirection(char direction)
        {
            int directionIndex = direction switch
            {
                'W' => 4,
                'N' => 3,
                'E' => 2,
                'S' => 1
            };

            return directionIndex;
        }

        private char EncodeDirection(int directionIndex)
        {
            char direction = directionIndex switch
            {
                4 => 'W',
                3 => 'N',
                2 => 'E',
                1 => 'S'
            };

            return direction;
        }

        private char Case11(char direction, List<int> commands)
        {
            int directionIndex = DecodeDirection(direction);

            foreach (var command in commands)
            {
                directionIndex += command;

                if (directionIndex > 4)
                    directionIndex -= 4;
                else if (directionIndex <= 0)
                    directionIndex = 1;
            }

            return EncodeDirection(directionIndex);
        }

        private (float element1, float element2, float element3) Case12(int elementIndex, float knownElement)
        {
            (float element1, float element2, float element3) elementsToFind = new();

            switch (elementIndex)
            {
                case 1:
                    elementsToFind = GetElementsByRadius(knownElement);
                    break;
                case 2:
                    elementsToFind = GetElementsByDiameter(knownElement);
                    break;
                case 3:
                    elementsToFind = GetElementsByLength(knownElement);
                    break;
                case 4:
                    elementsToFind = GetElementsBySquare(knownElement);
                    break;
            }

            return elementsToFind;
        }

        private (float element1, float element2, float element3) GetElementsByRadius(float radius)
        {
            float diameter = 2f * radius;
            float length = 2f * MathF.PI * radius;
            float square = MathF.PI * radius * radius;

            return (diameter, length, square);
        }

        private (float element1, float element2, float element3) GetElementsByDiameter(float diameter)
        {
            float radius = diameter / 2f;

            (float element1, float element2, float element3) elements = GetElementsByRadius(radius);

            elements.element1 = radius;

            return elements;
        }

        private (float element1, float element2, float element3) GetElementsByLength(float length)
        {
            float radius = length / 2f * MathF.PI;

            (float element1, float element2, float element3) elements = GetElementsByRadius(radius);

            elements.element2 = elements.element1;

            elements.element1 = radius;

            return elements;
        }

        private (float element1, float element2, float element3) GetElementsBySquare(float square)
        {
            float radius = MathF.Sqrt(square / MathF.PI);

            (float element1, float element2, float element3) elements = GetElementsByRadius(radius);

            elements.element3 = elements.element2;

            elements.element2 = elements.element1;

            elements.element1 = radius;

            return elements;
        }

        private (float element1, float element2) Case13(int elementIndex, float knownElement)
        {
            (float element1, float element2) elementsToFind = new();

            switch (elementIndex)
            {
                case 1:
                    elementsToFind = FindElementsByCathetus(knownElement);
                    break;
                case 2:
                    elementsToFind = FindElementsByHypotenuse(knownElement);
                    break;
                case 3:
                    elementsToFind = FindElementsByHeight(knownElement);
                    break;
            }

            return elementsToFind;
        }

        private (float element1, float element2) FindElementsByCathetus(float side)
        {
            float hypotenuse = side * MathF.Sqrt(2f);

            float height = hypotenuse / 2f;

            return (hypotenuse, height);
        }

        private (float element1, float element2) FindElementsByHypotenuse(float hypotenuse)
        {
            float side = hypotenuse / MathF.Sqrt(2f);

            float height = hypotenuse / 2f;

            return (side, height);
        }

        private (float element1, float element2) FindElementsByHeight(float height)
        {
            float hypotenuse = height * 2f;

            float side = hypotenuse / MathF.Sqrt(2f);

            return (side, hypotenuse);
        }

        private (float element1, float element2, float element3) Case14(int elementIndex, float knownElement)
        {
            (float element1, float element2, float element3) elementsToFind = new();

            switch (elementIndex)
            {
                case 1:
                    elementsToFind = FindElementsBySide(knownElement);
                    break;
                case 2:
                    elementsToFind = FindElementsByFirstRadius(knownElement);
                    break;
                case 3:
                    elementsToFind = FindElementsBySecondRadius(knownElement);
                    break;
                case 4:
                    elementsToFind = FindElementsBySquare(knownElement);
                    break;
            }

            return elementsToFind;
        }

        private (float element1, float element2, float element3) FindElementsBySide(float side)
        {
            float radiusOne = side * MathF.Sqrt(3f) / 6f;

            float radiusTwo = radiusOne * 2f;

            float square = side * side * MathF.Sqrt(3f) / 4f;

            return (radiusOne, radiusTwo, square);
        }

        private (float element1, float element2, float element3) FindElementsByFirstRadius(float firstRadius)
        {
            float side = (firstRadius * 6) / MathF.Sqrt(3f);

            float secondRadius = firstRadius * 2f;

            float square = side * side * MathF.Sqrt(3f) / 4f;

            return (side, secondRadius, square);
        }

        private (float element1, float element2, float element3) FindElementsBySecondRadius(float secondRadius)
        {
            float firstRadius = secondRadius / 2f;

            float side = (firstRadius * 6) / MathF.Sqrt(3f);

            float square = side * side * MathF.Sqrt(3f) / 4f;

            return (side, secondRadius, square);
        }

        private (float element1, float element2, float element3) FindElementsBySquare(float square)
        {
            float side = MathF.Sqrt((4f * square) / MathF.Sqrt(3f));

            float firstRadius = side * MathF.Sqrt(3f) / 6f;

            float secondRadius = firstRadius * 2f;

            return (side, firstRadius, secondRadius);
        }

        private (string name, string cardClass) Case15(int cardNumber, int cardClassNumber)
        {
            string cardClass = cardClassNumber switch
            {
                1 => "пик ",
                2 => "треф ",
                3 => "бубен ",
                4 => "червей ",
            };

            string name = cardNumber switch
            {
                6 => "шестерка",
                7 => "семерка",
                8 => "восьмерка",
                9 => "девятка",
                10 => "десятка",
                11 => "валет",
                12 => "дама",
                13 => "король",
                14 => "туз"
            };

            return (cardClass, name);
        }

        private string Case16(int age)
        {
            int lastAgeNumber = age % 10;

            int firstAgeNumber = age / 10;

            string ageName = lastAgeNumber switch
            {
                0 or 5 or 6 or 7 or 8 or 9 => " лет",
                1 => " год",
                2 or 3 or 4 => " года"
            };

            string lastNumberName = lastAgeNumber switch
            {
                1 => " один",
                2 => " два",
                3 => " три",
                4 => " четыре",
                5 => " пять",
                6 => " шесть",
                7 => " семь",
                8 => " восемь",
                9 => " девять",
                0 => ""
            };

            string firstNumberName = firstAgeNumber switch
            {
                2 => "двадцать",
                3 => "тридцать",
                4 => "сорок",
                5 => "пятьдесят",
                6 => "шестьдесят"
            };

            return firstNumberName + lastNumberName + ageName;
        }

        private string Case17(int taskCount)
        {
            if (taskCount / 10 == 1)
            {
                string result = taskCount switch
                {
                    10 => "десять",
                    11 => "одинадцать",
                    12 => "двенадцать",
                    13 => "тринадцать",
                    14 => "четырнадцать",
                    15 => "пятнадцать",
                    16 => "шестнадцать",
                    17 => "семнадцать",
                    18 => "восемнадцать",
                    19 => "девятнадцать",
                };

                return result + " учебных заданий";
            }

            int firstDecimal = taskCount / 10;

            string firstDecimalName = firstDecimal switch
            {
                2 => "двадцать",
                3 => "тридцать",
                4 => "сорок",
            };

            int secondDecimal = taskCount % 10;

            string secondDecimalName = secondDecimal switch
            {
                1 => " одно",
                2 => " два",
                3 => " три",
                4 => " четыре",
                5 => " пять",
                6 => " шесть",
                7 => " семь",
                8 => " восемь",
                9 => " девять",
                0 => ""
            };

            string countOfTasksName = secondDecimal switch
            {
                0 or 5 or 6 or 7 or 8 or 9 => " учебных заданий",
                1 => " учебное задание",
                2 or 3 or 4 => " учебных задания"
            };

            return firstDecimalName + secondDecimalName + countOfTasksName;
        }

        private string Case18(int number)
        {
            int hundreds = number / 100;
            int tens = number / 10 - hundreds * 10;
            int ones = number % 10;

            string hundredsName = (number / 100) switch
            {
                1 => "сто",
                2 => "двести",
                3 => "триста",
                4 => "четыреста",
                5 => "пятьсот",
                6 => "шестьсот",
                7 => "семьсот",
                8 => "восемьсот",
                9 => "девятьсот"
            };

            if (tens == 1)
            {
                int twoLastDecimals = number % 100;

                string twoLastDecimalsName = twoLastDecimals switch
                {
                    10 => " десять",
                    11 => " одинадцать",
                    12 => " двенадцать",
                    13 => " тринадцать",
                    14 => " четырнадцать",
                    15 => " пятнадцать",
                    16 => " шестнадцать",
                    17 => " семнадцать",
                    18 => " восемнадцать",
                    19 => " девятнадцать",
                };

                return hundredsName + twoLastDecimalsName;
            }

            string tensName = tens switch
            {
                2 => " двадцать",
                3 => " тридцать",
                4 => " сорок",
                5 => " пятьдесят",
                6 => " шестьдесят",
                7 => " семьдесят",
                8 => " восемьдесят",
                9 => " девяносто",
                0 => " "
            };

            string onesName = ones switch
            {
                1 => " один",
                2 => " два",
                3 => " три",
                4 => " четыре",
                5 => " пять",
                6 => " шесть",
                7 => " семь",
                8 => " восемь",
                9 => " девять",
                0 => " "

            };

            return hundredsName + tensName + onesName;
        }

        private string Case19(int year)
        {
            string startingColorName = (year % 10) switch
            {
                0 or 1 => "бел",
                2 or 3 => "черн",
                4 or 5 => "зелен",
                6 or 7 => "красн",
                8 or 9 => "желт",
            };

            string endingColorName = ((year + 1) % 5) switch
            {
                0 or 1 or 2 or 3 or 4 or 5 or 9 or 10 or 11 => "ой",
                6 or 7 or 8 => "ого"
            };

            string colorName = startingColorName + endingColorName;

            string animalName = ((year + 8) % 12) switch
            {
                1 => " крысы",
                2 => " коровы",
                3 => " тигра",
                4 => " зайца",
                5 => " дракона",
                6 => " змеи",
                7 => " лошади",
                8 => " овцы",
                9 => " обезьяны",
                10 => " курицы",
                11 => " собаки",
                12 => " свиньи",
            };

            return colorName + animalName;
        }

        private string Case20(int day, int month)
        {
            string zodiac = "";

            switch (month) 
            {
                case 1:
                    if (day > 19)
                        zodiac = "водолей";
                    else
                        zodiac = "козерог";
                    break;
                case 2:
                    if (day > 18)
                        zodiac = "рыбы";
                    else
                        zodiac = "водолей";
                    break;
                case 3:
                    if (day > 20)
                        zodiac = "овен";
                    else
                        zodiac = "рыбы";
                    break;
                case 4:
                    if (day > 19)
                        zodiac = "телец";
                    else
                        zodiac = "овен";
                    break;
                case 5:
                    if (day > 20)
                        zodiac = "близнецы";
                    else
                        zodiac = "телец";
                    break;
                case 6:
                    if (day > 21)
                        zodiac = "рак";
                    else
                        zodiac = "близнецы";
                    break;
                case 7:
                    if (day > 22)
                        zodiac = "лев";
                    else
                        zodiac = "рак";
                    break;
                case 8:
                    if (day > 22)
                        zodiac = "дева";
                    else
                        zodiac = "лев";
                    break;
                case 9:
                    if (day > 22)
                        zodiac = "весы";
                    else
                        zodiac = "дева";
                    break;
                case 10:
                    if (day > 22)
                        zodiac = "скорпион";
                    else
                        zodiac = "весы";
                    break;
                case 11:
                    if (day > 22)
                        zodiac = "стрелец";
                    else
                        zodiac = "скорпион";
                    break;
                case 12:
                    if (day > 21)
                        zodiac = "козерог";
                    else
                        zodiac = "стрелец";
                    break;

            }

            return zodiac;
        }
        #endregion
    }
}