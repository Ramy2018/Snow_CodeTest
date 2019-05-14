using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Snow_Code_Test
{
    public class Functions
    {
        /// <summary>
        /// Reverses a string.
        /// </summary>
        /// <param name="value">String to reverse.</param>
        /// <returns>Reversed string.</returns>
        public string ReverseString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return null;
            }
            //firstway without linq 
            //var charArray=value.ToCharArray();
            //Array.Reverse(charArray);
            //return new string(charArray);

            //secondway with linq
            return new string(value.Reverse().ToArray());


        }

        /// <summary>
        /// Calculates the Nth fibonacci number.
        /// </summary>
        /// <param name="n">Fibonacci number to calculate.</param>
        /// <returns>The nth fibonacci number.</returns>
        public int CalculateNthFibonacciNumber(int nthFibonacciNumber)
        {
            if (nthFibonacciNumber < 2)
                return nthFibonacciNumber;
         
            int firstNumber = 0; int secondNumber = 1; int result = 0;
            for (int i = 2 ; i <= nthFibonacciNumber; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }
            return result;
           
        }

        /// <summary>
        /// Pads a number with up to four zeroes, returning a string with a total length of five numerical characters.
        /// </summary>
        /// <param name="number">Number to pad.</param>
        /// <returns>Zero-padded number.</returns>
        /// <remarks>Can only pad unsigned numbers up to 99999.</remarks>
        public string PadNumberWithZeroes(int number)
        {
           
            string padNumber = number.ToString("D5");
            string info = "Number is to large";

            if (number > 99999)
                return info;
            if (number.ToString().Length > 5)
                return number.ToString();
            else
                return padNumber;
              
        }

        /// <summary>
        /// Determines if a year is a leap year.
        /// </summary>
        /// <param name="year">Year to determine.</param>
        /// <returns>True if leap year, false if not.</returns>
        public bool IsLeapYear(int year)
        {
            if (year <= 0)
                return false;
            if (year % 4 == 0 && year % 100 != 0)
                return true;
            else if (year % 100 == 0 && year % 400 == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Find the N:th largest number in a range of numbers.
        /// </summary>
        /// <param name="numbers">List of integers.</param>
        /// <returns>The third largest number in list.</returns>
        public int FindNthLargestNumber(List<int> numbers, int nthLargestNumber)
        {
            if (numbers.Count == 0)
                return 0;
              //This return third largest number for testing purpose comment out
             //nthLargestNumber = 3;
             return numbers.OrderByDescending(x => x).Distinct().Skip(nthLargestNumber - 1).FirstOrDefault();
            

        }

        /// <summary>
        /// Selects all prime numbers from an enumerable with numbers.
        /// </summary>
        /// <param name="numbers">Enumerable with numbers.</param>
        /// <returns>An enumerable with only prime numbers.</returns>
        public  IEnumerable<int> selectprimenumbers(IEnumerable<int> numbers)
        {
            if (!numbers.Any())
                return null;
            var newList = new List<int>();
            var primeList = new List<int>();
            foreach (var item in numbers)
            {
                newList.Add(item);
            }
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] <= 0)
                    continue;
                int startValue = 2;
                bool isPrime = true;
                while (startValue < newList[i])
                {
                    if (newList[i] % startValue == 0)
                    {
                        isPrime=false;
                        break;
                    }
                    startValue++;
                }

                if (isPrime)
                {
                    primeList.Add((newList[i]));
                }
            }
            return primeList;
        }

        /// <summary>
        /// Determines if the bit pattern of value the same if you reverse it.
        /// </summary>
        /// <param name="value">Value to inspect.</param>
        /// <returns>True if the bit value is a palindrome otherwise false.</returns>
        public bool IsPalindrome(int value)
        {
          
            var originBit = Convert.ToString(value, 2);
            var reverseBit = new string(Convert.ToString(value, 2).Reverse().ToArray());
            if (originBit == reverseBit)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Counts all set bits in an int value.
        /// </summary>
        /// <param name="value">Integer value to count bits in.</param>
        /// <returns>Number of set bits in integer value.</returns>
        public  int CountSetBits(int value)
        {
            return Convert.ToString(value, 2).Count(x => x == '1');
        }
    }
}
