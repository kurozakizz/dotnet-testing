# Install .NET SDK
- [Get started with .NET in 10 minutes](https://www.microsoft.com/net/learn/get-started/macos)

# Create new xunit project
```sh
dotnet new xunit -o dotnet-testing
cd dotnet-testing
```

# Run test
```sh
dotnet test
```

# Use [Theory]

Example of inject test data as a list of test case into single test case

LogAnalyzer.cs

![LogAnalyzer](https://raw.githubusercontent.com/kurozakizz/dotnet-testing/master/screenshots/LogAnalyzer.png)

LogAnalyzerTests.cs

![LogAnalyzerTests](https://raw.githubusercontent.com/kurozakizz/dotnet-testing/master/screenshots/LogAnalyzerTests.png)

# Use [Fact]

Example of split test case into each case

MemCalculator.cs

![MemCalculator](https://raw.githubusercontent.com/kurozakizz/dotnet-testing/master/screenshots/MemCalculator.png)

MemCalcualtorTests.cs

![MemCalculatorTests](https://raw.githubusercontent.com/kurozakizz/dotnet-testing/master/screenshots/MemCalculatorTests.png)