using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amps.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;

namespace Amps.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new List<Amp>();
            var ampsCurationList = new[]
            {
                "fender-deville-ml",
                "fender-68-custom-vibrolux",
                "fender-68-custom-deluxe",
                "fender-bassbreaker-18-30",
                "fender-bassbreaker-45"
            };

            foreach (var slug in ampsCurationList)
            {
                var amp = JsonConvert.DeserializeObject<Amp>(
                    System.IO.File.ReadAllText($@"C:\Users\mipelleg\Sites\Amps\Amps\Json\{slug}.json"));
                viewModel.Add(amp);
            }
            return View("Views/Home/Index.cshtml", viewModel.ToArray());
        }
    }
}
