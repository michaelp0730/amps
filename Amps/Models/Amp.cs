using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amps.Models
{
    public class Amp
    {
        public string Slug { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string SpeakerConfiguration { get; set; }
        public int Watts { get; set; }
        public int MSRP { get; set; }
        public string Url { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal Weight { get; set; }
    }
}
