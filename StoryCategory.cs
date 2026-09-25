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
        
    }
}
