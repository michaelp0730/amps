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
        public string SpeakerType { get; set; }
        public int Watts { get; set; }
        public int MSRP { get; set; }
        public string Url { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal Weight { get; set; }
        public bool HasEffectsLoop { get; set; }
        public bool HasReverb { get; set; }
        public bool HasTremolo { get; set; }
        public string PreampTubes { get; set; }
        public string PowerampTubes { get; set; }
        public string Rectifier { get; set; }
        public Article[] Articles { get; set; }
        public string[] Videos { get; set; }
        public int Channels { get; set; }
        public string Inputs { get; set; }
        public string Outputs { get; set; }
        public string Eq { get; set; }
        public bool HasFootswitch { get; set; }
        public string[] Pros { get; set; }
        public string[] Cons { get; set; }
    }
}
