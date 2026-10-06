using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class Events
    {
        private string _events; 
        public string BigEvents { get; set; } // big event(s) that help flesh out the story and hold a majority of the story line / plot

        public string SmallInteractions { get; set; } // charcters meets with one another for the first time ,
                                                      // that may lead into another interaction, or group

        public string Incidents { get; set; } // similar to Big events but encase events that are all realated eg: bunny within the forrest 
                                              // goes down a hole to find a golden carrot only which leads to other animals involved in the carrot.
        public string Celebration { get; set; } // characters celebrate events that are key to story prgression ( can be losse or rigid)

        public string Crisis { get; set; }  // very inportant with in the story would go well with the beginning and climax, which seek a resolution 
    }
}
