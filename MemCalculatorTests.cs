using Xunit;

namespace dotnet_testing
{
    public class MemCalculatorTest
    {
      [Fact]
      public void Test_Sum_Default_ShouldReturn_0()
      {
        int expected = 0;
        MemCalculator calc = new MemCalculator();

        int actual = calc.Sum();
        
        Assert.Equal(expected, actual);
      }
    }
}