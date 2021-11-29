using System;
using Xunit;

namespace MyFirstMvcApp.Tests
{
    public class TestExamples
    {
        //[Fact] // It is a test
        [Theory] // should have parameters
        [InlineData(2, 10, 1024)]
        [InlineData(3, 3, 27)]
        [InlineData(4, 4, 256)]
        public void TestMathPowShouldReturn1024WhenGiven2And10(int num, int exp, int expectedResult)
        {
            // Console.WriteLine("Hello from test"); - Resharper
            // Arrange
            // Act 
            //var result = Math.Pow(2, 10);
            var result = Math.Pow(num, exp);
            // Assert 
            //Assert.Equal(1024, result);
            //Assert.Equal(1023, result);
            Assert.Equal(expectedResult, result);
            //if (result != 1024)
            //{
            //    throw Exception("Not 1024");
            //}
        }

        [Fact]
        public void StringEqualsTest()
        {
            Assert.Contains("Softuni", "Hello, Softuni!"); // by analizer
            //Assert.True("Hello, Softuni!".Contains("Softuni"));
        }
    }
}
