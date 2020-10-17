using Hangfire;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.Encodings.Web;

namespace aspnetjobs.Controllers
{
    public class JobsController : Controller
    {
        public string Index()
        {
            var numbers = Enumerable.Range(1, 100000).Select(x => x);
            foreach (var num in numbers)
            {
                BackgroundJob.Enqueue(() => System.Console.WriteLine("Number is " + num));
            }

            return "This is my default action...";
        }

    }
}