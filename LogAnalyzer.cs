namespace dotnet_testing
{
    public class LogAnalyzer 
    {
      public bool IsValidLogFileName(string fileName) 
      {
        if (fileName.EndsWith((".log"))) 
        {
          return true;
        }
        return false;
      }
    }
}