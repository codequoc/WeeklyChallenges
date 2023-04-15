using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            int num = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    num += numbers[i];
                } else
                {
                    num -= numbers[i];
                }
            }
            return num;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var numList = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return numList.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var num = new List<int> { number1, number2, number3, number4 };
            return num.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return ( sideLength1 + sideLength2  > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;
            var count = 0;
            foreach ( var obj in objs )
            {
               if (obj == null)
                {
                    count++;
                }
            }

            if (count >= majority)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var average = numbers.Where(x => x % 2 == 0);
            if (average.Count() == 0)
            {
                return 0;
            }
            return average.Average();
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number *  Factorial(number - 1);
        }
    }
}
