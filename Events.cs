using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class Events
    {
        public List<Tag> Tags = new List<Tag>();
        public string? Title { get; set; }
        public int? Order { get; set; }
        public List<Events> CausedBy { get; set; } = new List<Events>(); // cause and effect
        public EventType Type { get; set; }
        public StoryPhase Phase { get; set; }

        public string? Description { get; set; }

        public List<Character> CharactersInvolved { get; set; } = new List<Character>(); // characters involved in the event 
        public List<StoryLocation> LocationOfEvent { get; set; } = new List<StoryLocation>();// where the Event takes place withing the story
    }
    public enum EventType
    {
        Unknown,
        SmallInteractions, // charcters meets with one another for the first time that may lead into another interaction, or group
        Incident, // related events chained together, eg bunny finds golden carrot, other animals get involved etc.
        Celebration,  // characters celebrate events that are key to story progression
        Crisis, // very important, pairs with the beginning and climax, seeks a resolution
        BigEvent // big event(s) that help flesh out the story and hold a majority of the story line / plot
    }

    public enum StoryPhase
    { Unknown, Setup, RisingAction, Climax, FallingAction, Resolution }


}