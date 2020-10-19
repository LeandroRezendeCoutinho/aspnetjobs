using Hangfire;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace aspnetjobs.Controllers
{
  public class JobsController : Controller
  {
    public string Index()
    {
      var numbers = Enumerable.Range(1, 100000).Select(x => x);
      foreach (var num in numbers)
      {
        BackgroundJob.Enqueue(() => WriteAsync(num));
      }

      return "This is my default action...";
    }

    public async Task WriteAsync(int num)
    {
      System.Console.WriteLine("Number is " + num);
      await Task.Delay(1);
    }
  }
}