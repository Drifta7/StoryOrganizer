using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoryOrganizer
{
    // this is where the user will store their ideas with no reservations.
    public class BrainStormDump
    {
        public string Content { get; set; } // the content(raw random ideas) that the user will put into the field 
        public int BatchContentNum { get; set; } // this will note the batch number of dumps that the user will have 
    }
}
