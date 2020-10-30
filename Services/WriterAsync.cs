
using System.Threading.Tasks;

namespace aspnetjobs.Services
{
  public class WriterAsync
  {
    public async Task WriteAsync(int num)
    {
      await FibonacciAsync(10);
      System.Console.WriteLine("Number is " + num);
    }

    private async Task<int> FibonacciAsync(int n)
    {
      return await Task.Run(
          async () =>
          {
            if (n < 2)
            {
              return 1;
            }
            else
            {
              var result = await Task.WhenAll<int>(FibonacciAsync(n - 1), FibonacciAsync(n - 2));
              return result[0] + result[1];
            }
          }
          );
    }
  }
}