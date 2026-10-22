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
        public List<Tag> Tags { get; } = new List<Tag>(); // Master list: every tag in the story is created once, here 

         public static Tag? FindTag(Story story, string tagName)
        {
            foreach (Tag tag in story.Tags)
            {
                if (tag.Name.Equals(tagName.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return tag;
                }
            }
            return null;
        }

        public static Tag CreateTag(Story story, string tagName, String color)
        {
            Tag newTag = new Tag { Name = tagName.Trim(), Color = color };
            story.Tags.Add(newTag);// created once, owned by the story
            return newTag;
        }
    }
}
