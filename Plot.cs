using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class Plot
    {
        private string _plot;

        // user will get to choose either beginning, middle, end and work accordingly 

        public string Beginning { get; set; } // start of the story
        public string Middle { get; set; } // where the story developes, meat and potatoes of the story 
        public string Ending { get; set; } // where the stroy closes 

        public string Climax { get; set; } // where the story may peak 
        public string PotentialPlotTwist { get; set; } // to "spice" up the story

        public string NewCharacterIntroduction { get; set; }
       
        public List<string> MulitplePlotCharacters = new List<string>(); // this will be for if/when characters are introduced 
                                                                        // within different parts of the plot 

        public string PossibleFillers { get; set; } // things that may develop the story, plot ior characters

        public string StoryClues { get; set; } // "items" that may be of use for the story and it's characters eg : special key, haunted building, 
                                               // book from the dark ages with spells.

        public string SeriesOfEvents { get; set; } // help chornologically put events into place

        public string CauseAndEffect { get; set; } // why the events in the plot happen 

        public string RisingAction { get; set; } // the events and conflicts that build suspense, tension and complications 

       

        public string PlotPregression  // which characters and themes would push the plot further, as opposed to having the characters just exist
        {
            get { return _plot; }
            set { _plot = value; }
        }


    }
}
