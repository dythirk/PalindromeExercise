using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("a", true)]
        [InlineData("abc", false)]
        [InlineData("1", true)]
        [InlineData("12", false)]
        [InlineData("121", true)]
        [InlineData("face", false)]
        [InlineData("racecar", true)]
        [InlineData("Racecar", false)]
        [InlineData("Panama", false)]
        [InlineData("amanaplanacanalpanama", true)]
        public void IsAPalindromeTest(string phrase, bool expected)
        {
            //Arrange
            var wordSmithTestClass = new WordSmith();

            //Act
            var actual = wordSmithTestClass.IsAPalindrome(phrase);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
