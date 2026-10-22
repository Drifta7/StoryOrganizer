using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoryOrganizer
{
    // this is where the user will store their ideas with no reservations.
    public class IdeaCanvasDump
    {
        public List <Tag> Tags { get; set; }
      
        public List<string> DumpArea { get; set; }
        
        public IdeaCanvasDump() // construtor
        {
             DumpArea = new List<string>(); // this to displayed within the for each loop in Main() function/Method
        }
    }
}
