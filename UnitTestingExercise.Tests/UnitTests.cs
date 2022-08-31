using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, 3, 3, 9)]
        [InlineData(4, 4, 5, 13)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(1,1, 1, 3)]
        [InlineData(2, 2, -4, 0)]
        //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator challenge = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = challenge.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 6, -3)]//Add test data <-------
        [InlineData(6 , 3, 3)]
        [InlineData(8, -1, 9)]
        [InlineData(-2, 2, -4)]
        [InlineData(78, 25, 53)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            //Act
            var actual = Calculator.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected , actual);
        }

        [Theory]
        [InlineData(3, 3, 9)]//Add test data <-------
        [InlineData(8, 0, 0)]
        [InlineData(7, 8, 56)]
        [InlineData(9, -9, -81)]
        [InlineData(0, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator challenge = new Calculator();
            //Act
            var actual = challenge.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(81, 9, 9)]
        [InlineData(0, 8, 0)]
        [InlineData(25, 5, 5)]
        [InlineData(36, 9, 4)]
        //Add test data <-------
        public void DivideTest(int num1, int num2, double expected)
        {
            //Arrange
            Calculator challenge = new Calculator();
            //Act
            var actual = challenge.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
