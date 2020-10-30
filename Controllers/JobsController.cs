using aspnetjobs.Services;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace aspnetjobs.Controllers
{
  public class JobsController : Controller
  {
    public string Index()
    {
      var numbers = Enumerable.Range(1, 10_000);
      foreach (var num in numbers)
      {
        BackgroundJob.Enqueue(() => new WriterAsync().WriteAsync(num));
      }

      return "This is my default action...";
    }
  }
}