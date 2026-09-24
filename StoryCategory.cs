using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class StoryCategory
    {
        // might change this to a Plot class 
        public string Category { get; set; }

        public static List<string> storyCategories = new List<string>();
        public static List<string> mainCharcterAttributes = new List<string>();
        public static List<string> mainCharctersGoals = new List<string>();

        // user will get to choose either beginning, middle, end and work accordingly 
        public string Beginning { get; set; } // start of the story
        public string Middle { get; set; } // where the story developes, meat and potatoes of the story 
        public string Ending { get; set; } // where the stroy closes 

        public string Climax { get; set; } // where the story may peak 
        public string PotentialPlotTwist { get; set; } // to "spice" up the story


    }
}
