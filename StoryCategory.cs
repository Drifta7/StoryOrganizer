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
        private string _category { get; set; } // field 

        public string Category 
        {
            get { return _category; } //reads 
            set // writes
            {
                List<string> List = new List<string>();
            }
        }


        public static List<string> storyCategories = new List<string>();
        
    }
}
