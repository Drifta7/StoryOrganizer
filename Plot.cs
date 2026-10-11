using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class Plot
    {
        public List<Tag>? Tags { get; set; } // tags for the plot
        
        private string? _plot;

        // user will get to choose either beginning, middle, end and work accordingly 
       
        public string? Beginning { get; set; } // start of the story
        public string? Middle { get; set; } // where the story developes, meat and potatoes of the story 
        public string? Ending { get; set; } // where the stroy closes 

        public string? Climax { get; set; } // where the story may peak 
        public List<PlotTwist> PlotTwists { get; } = new List<PlotTwist>(); // to "spice" up the story

        public string? PossibleFillers { get; set; } // things that may develop the story, plot or characters

        public string? PlotPregression  // which characters and themes would push the plot further, as opposed to having the characters or events just exist
        {
            get { return _plot; }
            set { _plot = value; }
        }
    }
}
