using System.Collections.Generic;
using Amps.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Amps.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new List<Amp>();
            var ampsCurationList = new[]
            {
                "drz-maz-18",
                "fender-68-custom-deluxe",
                "fender-68-custom-vibrolux",
                "fender-bassbreaker-18-30",
                "fender-bassbreaker-45",
                "fender-deville-ml",
                "jet-city-2212C",
                "soldano-astroverb",
                "supro-black-magick",
                "supro-rhythm-master",
                "supro-royal-reverb",
                "supro-saturn-reverb",
                "supro-tremo-verb",
                "yamaha-thr100-hd"
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
