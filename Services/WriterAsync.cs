
using System.Threading.Tasks;

namespace aspnetjobs.Services
{
  public class WriterAsync
  {
    public static async Task WriteAsync(int num)
    {
      System.Console.WriteLine("Number is " + num);
      await Task.Delay(1);
    }
  }
}