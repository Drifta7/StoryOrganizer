using System;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StoryOrganizer
{
    public class Story
    {
        public List<Relationship> Relationships { get; } = new List<Relationship>();
        public string Title { get; set; } = string.Empty;
        public PlotSystem Plot { get; } = new PlotSystem();
        public List<Character> Characters { get; } = new List<Character>();
        public List<StoryLocation> Locations { get; } = new List<StoryLocation>();
        public List<string> CustomGenres { get; } = new List<string>();

        public Genres genres { get; set; }

        public List<Events> Events { get; } = new List<Events>();
        public List<StoryItem> Items { get; } = new List<StoryItem>();
        public List<Tag> Tags { get; } = new List<Tag>(); // Master list: every tag in the story is created once, here 

        public Tag? FindTag(string tagName)
        {
            foreach (Tag tag in Tags)
            {
                if (tag.Name.Equals(tagName.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return tag;
                }
            }
            return null;
        }

        public Tag CreateTag(string tagName, String color)
        {
            Tag newTag = new Tag { Name = tagName.Trim(), Color = color };
            Tags.Add(newTag);// created once, owned by the story
            return newTag;
        }
        public StoryLocation? FindOrCreateLocation(string? locationName)
        {
            if (string.IsNullOrWhiteSpace(locationName))
            {
                return null; // left blank or no location
            }
            string trimmedLocationName = locationName.Trim();
            foreach (StoryLocation location in Locations)
            {
                if (location.Name.Equals(locationName.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return location;
                }
            }
            StoryLocation newLocation = new StoryLocation { Name = locationName.Trim() };
            Locations.Add(newLocation);// create once, owned by the Story
            return newLocation;

        }
        public Tag? FindOrCreateTag(string? tagName)
        {
            if (string.IsNullOrEmpty(tagName))
            {
                return null;
            }
            string trimmedTagName = tagName.Trim();
            foreach (Tag tag in Tags)
            {
                if (tag.Name.Equals(tagName.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return tag;
                }
            }
            Tag newTag = new Tag { Name = trimmedTagName, Color = "Unknown" };
            Tags.Add(newTag);
            return newTag;
        }
        public Story CheckingDoubleGenre(string? customGenre)
        {
            if (string.IsNullOrEmpty(customGenre))
            {
                return null;
            }
            string trimmedCustom = customGenre.Trim();
            foreach ( string genre in CustomGenres)
            {
                if (genre.Equals(trimmedCustom.Trim(), StringComparison.OrdinalIgnoreCase))

                {
                    return genre;
                }
            }
        }
    }
    public enum Genres { Fantsy, horror, adventure, ScienceFiction, romnace, OneShot  }
}
