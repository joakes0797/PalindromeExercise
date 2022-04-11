using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("dog", false)]
        [InlineData("radaR", true)]
        [InlineData("AManAPlanACanalPanama", true)]
        [InlineData("racecar", true)]
        [InlineData("Hannah", true)]
        [InlineData("Jill", false)]

        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            var palTest = new WordSmith();

            //Act
            var actual = palTest.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
