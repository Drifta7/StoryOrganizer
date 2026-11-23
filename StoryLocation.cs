namespace StoryOrganizer
{
    public class StoryLocation
    {
        public List<Tag>? Tags { get; set; } = new List<Tag>();  //points to tags in Story.Tags, never new ones

        public string? Description { get; set; }

        public StoryLocation? Parent { get; set; }

        public string Name { get; set; } = String.Empty; // String.Empty provides a valid, blank string,which in turn can use length or other string operations

        public string? Address { get; set; }

    }
}
