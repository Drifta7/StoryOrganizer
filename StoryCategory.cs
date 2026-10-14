using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class StoryCategory
    {
        public List<Tag>? Tags { get; set; }
        // might change this to a Plot class 
        private string _category = string.Empty;

        public string Category 
        {
            get { return _category; } //reads 
            set // writes
            {
                _category = value;
            }
        }
        public static List<string> multiGenreStory = new List<string>(); //for if stories have more than one genre  

        public static List<string> storyCategories = new List<string>(); // this will be for selecting more than one category
                                                                        // already in UiMethods
    }
}
