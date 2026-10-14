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
        public List <Tag> Tags { get; set; }
        public string? Content { get; set; } // the content(raw random ideas) that the user will put into the field 
       
        public int BatchContentNumber { get; set; } // this will note the batch number of dumps that the user will have 
        public List<string> DumpArea { get; set; }
        
        public BrainStormDump() // construtor
        {
             DumpArea = new List<string>(); // this to displayed within the for each loop in Main() function/Method
        }
    }
}
