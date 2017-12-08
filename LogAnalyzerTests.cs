using System;
using Xunit;

namespace dotnet_testing
{
    public class LogAnalyzerTests
    {
        [Fact]
        public void Test_IsValidLogFileName_PngExtension_ShouldReturn_False()
        {
            // arrange
            LogAnalyzer logAnalyzer = new LogAnalyzer();

            // act
            bool actual = logAnalyzer.IsValidLogFileName("filename.png");

            // assert
            Assert.False(actual);
        }
    }
}
