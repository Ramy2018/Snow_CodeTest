using Snow_Code_Test;
using System;
using System.Collections.Generic;
using Xunit;

namespace Function_Test_Code
{
    public class Functions_Tests
    {
        //creating one instance for all tests
        public static Functions functions= new Functions();
        [Fact]
        public void CheckingStringReturn_A_ReverseString()
        { 
            //Act
            string value1 = "Reverse";
            string value2 = "";
            //Arrange
            var result1=functions.ReverseString(value1);
            var result2=functions.ReverseString(value2);

            //Assert
            Assert.Equal("esreveR", result1);
            Assert.Null(result2);

        }
        [Fact]
        public void Calculates_TheNthFibonacciNumber()
        {
            //Act
            int fifthFibonacciNumber = 5;
            int firstFibonacciNumber = 1;
            //Arrange
            var result1 = functions.CalculateNthFibonacciNumber(fifthFibonacciNumber);
            var result2 = functions.CalculateNthFibonacciNumber(firstFibonacciNumber);

            //Assert
            Assert.Equal(5, result1);
            Assert.Equal(1, result2);
        }
        [Fact]
        public void Checking_MethodReturn5NumericalChar_WithFourLeadingZeros()
        {
            //Act
            int num1 = 99999;
            int num2 = 5;
            int num3 = 1000;

            //Arrange
            var result1 = functions.PadNumberWithZeroes(num1);
            var result2 = functions.PadNumberWithZeroes(num2);
            var result3 = functions.PadNumberWithZeroes(num3);

            //Assert
            Assert.Equal("99999", result1);
            Assert.Equal("00005", result2);
            Assert.Equal("01000", result3);
         
        }
        [Fact]
        public void Checking_IfTheYearIsA_LeapYear()
        {
            //Act
            int year1 = 0;
            int year2 = 2000;
            int year3 = 2012;
            int year4 = 1800;
            int year5 = -1800;

            //Arrange
            var result1 = functions.IsLeapYear(year1);
            var result2 = functions.IsLeapYear(year2);
            var result3 = functions.IsLeapYear(year3);
            var result4 = functions.IsLeapYear(year4);
            var result5 = functions.IsLeapYear(year5);

            //Assert
            Assert.False(result1);
            Assert.True(result2);
            Assert.True(result3);
            Assert.False(result4);
            Assert.False(result5);

        }
        [Fact]
        public void Checking_N_thLargestNumberInARangeOfNumbers()
        {
            //Act
            int thirdLargestNumber = 3;
            int fourthLargestNumber = 4;
            var numberList1 = new List<int> { 1, 2, 33, -33,-77,44, 55, 55, 66, 66, 89,89, 100 };
            var numberList2 = new List<int> { };

            //Arrange
            var result1 = functions.FindNthLargestNumber(numberList1, thirdLargestNumber);
            var result2 = functions.FindNthLargestNumber(numberList1, fourthLargestNumber);
            var result3 = functions.FindNthLargestNumber(numberList2, fourthLargestNumber);

            //Assert
            Assert.Equal(66, result1);
            Assert.Equal(55, result2);
            Assert.Equal(0, result3);

        }
        [Fact]
        public void Checking_allPrimeNumbersFromAnEnumerableWithNumbers()
        {
            //Act
            IEnumerable<int> numbersList1 = new List<int> { 0, 2, 3, 5, 6, 27, 15, 49, -22, 37, 35, 34, 11, 1222, 337, 400, -11, -44 };
            IEnumerable<int> numbersList2 = new List<int> { 55,66,2345,222,1020,-110,4543,234,13 };
            IEnumerable<int>numbersList3 = new List<int> {};

            IEnumerable<int> expectedNumbersList1 = new List<int> { 2, 3, 5, 37, 11, 337 };
            IEnumerable<int> expectedNumbersList2 = new List<int> { 13 };

            //Arrange
            var result1 = functions.selectprimenumbers(numbersList1);
            var result2 = functions.selectprimenumbers(numbersList2);
            var result3 = functions.selectprimenumbers(numbersList3);

            //Assert
            Assert.Equal(expectedNumbersList1, result1);
            Assert.Equal(expectedNumbersList2, result2);
            Assert.Null(result3);
            

        }
        [Fact]
        public void DeterminesBitValueOfInt_IsPalindrome()
        {
            //Act
            int value1 = 10;
            int value2 = -5;
            int value3 = 5;

            //Arrange
            var result1 = functions.IsPalindrome(value1);
            var result2 = functions.IsPalindrome(value2);
            var result3 = functions.IsPalindrome(value3);

            //Assert
            Assert.False(result1);
            Assert.False(result2);
            Assert.True(result3);
        }
        [Fact]
        public void CountsAllSetBitsInAn_IntValue()
        {
            //Act
            int value1 = 4;
            int value2 = 9;

            //Arrange
            var result1 = functions.CountSetBits(value1);
            var result2 = functions.CountSetBits(value2);

            //Assert
            Assert.Equal(1,result1);
            Assert.Equal(2,result2);

        }
    }
}
