using System;
using Xunit;

namespace dotnet_testing
{
    public class LogAnalyzerTests
    {
        private LogAnalyzer logAnalyzer = null;

        public LogAnalyzerTests()
        {
            logAnalyzer = new LogAnalyzer();
        }

        public void Dispose()
        {
            logAnalyzer = null;
        }

        [Theory]
        [InlineData("filename.png", false)]
        [InlineData("filename.log", true)]
        public void TestIsValidLogFileName(string fileName, bool expected)
        {
            bool actual = logAnalyzer.IsValidLogFileName(fileName);
            Assert.Equal(expected, actual);
        }
    }
}
