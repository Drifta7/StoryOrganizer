using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class PlotTwist
    {
        public List<Tag> Tags { get; set; }
        public string Description { get; set; } = string.Empty;
        public Events? RevealEvent { get; set; }
        public List<Events> ForeshadowEvents { get; set; } = new List<Events>();

        public List<Character> CharatersInPlotTwist { get; set; } = new List<Character>(); // are they the same characters within the orginal plot?

        public List<StoryLocation> WhereThePlotTwistHappens { get; set; } = new List<StoryLocation>();
    }
}
