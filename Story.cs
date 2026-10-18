using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class Story
    {
        public List<Relationship> Relationships { get; } = new List<Relationship>();
        public string Title { get; set; } = string.Empty;
        public PlotSystem Plot { get; } = new PlotSystem();
        public List<Character> Characters { get; } = new List<Character>();
        public List<StoryLocation> Locations { get; } = new List<StoryLocation>();

        public List<Events> Events { get; } = new List<Events>();
        public List<StoryItem> Items { get; } = new List<StoryItem>();
    }
}
