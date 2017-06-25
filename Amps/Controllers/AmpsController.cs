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
    public class AmpsController : Controller
    {
        [Route("/amps/{slug}")]
        public ViewResult AmpDetails(string slug)
        {
            var amp = JsonConvert.DeserializeObject<Amp>(
                System.IO.File.ReadAllText($@"C:\Users\mipelleg\Sites\Amps\Amps\Json\{slug}.json"));
            return View("Views/Amps/_details.cshtml", amp);
        }
    }
}
