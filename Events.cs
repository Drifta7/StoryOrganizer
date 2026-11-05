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
        public EventType Type { get; set; } // related to the enums
        public StoryPhase Phase { get; set; } // related to the enums

        public string? Description { get; set; }

        public List<Character> CharactersInvolvedInEvent { get; set; } = new List<Character>(); // characters involved in the event 
        public List<StoryLocation> LocationOfEvent { get; set; } = new List<StoryLocation>();// where the Event takes place withing the story

        public List<Story> MiscellaneousEvents { get; set; } = new List<Story>();// this is for extra events that are not covered by enums.

    }
    public enum EventType
    {
        Unknown,
        SmallInteractions, // charcters meets with one another for the first time that may lead into another interaction, or group
        Incident, // related events chained together, eg bunny finds golden carrot, other animals get involved etc.
        Celebration,  // characters celebrate events that are key to story progression
        Crisis, // very important, pairs with the beginning and climax, seeks a resolution
        BigEvent, // big event(s) that help flesh out the story and hold a majority of the story line / plot
        MinorConversations,// conversations between supporting characters that may or may not be a big peace of the story 
        ParadigmShift, // A truth bomb, a secret that has been revealed, defeat that pushed the protagonist to stop reacting and start proactive fight back
        TheStatusQuo,// The Normal Day: An event showing how the protagonist lives before the story begins, highlighting what they lack or what they are comfortable with.    }
        HintOfTrouble, // A small, overlooked anomaly, warning, or sign that the current way of living cannot last.
        TheDisruption, //An external event that breaks the protagonist's normal routine. (e.g., a messenger arrives, a crime is discovered, a job is lost, an invitation is delivered).
        TheForecedChoice, // The moment the protagonist is dragged out of their comfort zone and can no longer stay passive.
        ThePinchPointPressureSpike, //An event showing the antagonist's true power ior skill, reminding the protagonist how much is at stake.
    }
    public enum StoryPhase
    { Unknown, Setup, RisingAction, Climax, FallingAction, Resolution }
}