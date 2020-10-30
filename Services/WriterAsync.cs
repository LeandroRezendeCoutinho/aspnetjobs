
using System.Threading.Tasks;

namespace aspnetjobs.Services
{
  public class WriterAsync
  {
    public async Task WriteAsync(int num)
    {
      System.Console.WriteLine("Number is " + num);

      await Task.Delay(delay());
    }

    private int delay()
    {
      System.Random random = new System.Random();
      return random.Next(1, 10);
    }
  }
}