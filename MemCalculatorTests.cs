using Xunit;

namespace dotnet_testing
{
    public class MemCalculatorTest
    {
      [Fact]
      public void Test_Sum_Default_ShouldReturn_0()
      {
        int expected = 0;
        MemCalculator calc = MakeCalc();

        int actual = calc.Sum();

        Assert.Equal(expected, actual);
      }

      [Fact]
      public void Test_Add1_ShouldReturn_1()
      {
        int expected = 1;
        MemCalculator calc = MakeCalc();

        calc.Add(1);
        int actual = calc.Sum();

        Assert.Equal(expected, actual);
      }

      [Fact]
      public void Test_Add123_ShouldReturn_6()
      {
        int expected = 6;
        MemCalculator calc = MakeCalc();

        calc.Add(1);
        calc.Add(2);
        calc.Add(3);
        int actual = calc.Sum();

        Assert.Equal(expected, actual);
      }

      private static MemCalculator MakeCalc()
      {
          return new MemCalculator();
      }

    }
}