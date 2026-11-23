namespace StoryOrganizer
{
    public class StoryItem
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } // what the potential item looks like 
        public Character? Owner { get; set; } // who owns the item

        public StoryLocation? Location { get; set; }  // "items" that may be of use for the story and it's characters eg : special key, haunted building, 
                                                      // book from the dark ages with spells.
    }
}
