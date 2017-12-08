using System;
using Xunit;

namespace dotnet_testing
{
    public class LogAnalyzerTests
    {
        [Theory]
        [InlineData("filename.png", false)]
        [InlineData("filename.log", true)]
        public void Test_IsValidLogFileName_PngExtension_ShouldReturn_False(string fileName, bool expected)
        {
            // arrange
            LogAnalyzer logAnalyzer = new LogAnalyzer();

            // act
            bool actual = logAnalyzer.IsValidLogFileName(fileName);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
