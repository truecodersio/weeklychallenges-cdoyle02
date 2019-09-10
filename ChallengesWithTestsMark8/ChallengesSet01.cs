using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var Sum = minuend - subtrahend;
            return Sum; 
        }

        public int Add(int number1, int number2)
        {
            var Sum = number1 + number2;

            return Sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if(number1 > number2)
            {
                return number2;
            }
            else
            {
                return number1;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            var result = factor1 * factor2;
            return result;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                var s = "Hello" + ", " + nameOfPerson + "!";
                return s;
            }
        }

        public string GetHey()
        {
            var s = "HEY!";
            return s;
        }
    }
}
