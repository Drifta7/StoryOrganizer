using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class Tag
    {
        //  purpose of this class will be to help the user to tag certain parts to the their 
        // ideas to the story, most likey to be color coded and will be a visual aid and Part of the UI 
        public string Name { get; set; } = string.Empty;
        public string Color { get; set; } = "#808080"; // hex color for UI,  eg: "#E5533D" (red); grey until chosen
    }
}
