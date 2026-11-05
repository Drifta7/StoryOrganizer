using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class SampleStoryTester
    {
        // builds a complete, hard-coded story so the UI has data to show without typing anything
        // order matters: anything that is pointed TO (locations, tags) is created before the things that point to it
        public static Story Create()
        {
            Story story = new Story();
            story.Title = "Signal at Kestrel Deep";

            // ---------------- LOCATIONS (created once, kept in variables) ----------------
            StoryLocation station = new StoryLocation { Name = "Kestrel Deep Station", Description = "An undersea mining colony, 2190" };
            StoryLocation commandDeck = new StoryLocation { Name = "Command Deck", Description = "Where the station is run", Parent = station };
            StoryLocation recordingBooth = new StoryLocation { Name = "Recording Booth", Description = "A soundproof room off the crew quarters", Parent = station };
            StoryLocation hydroponics = new StoryLocation { Name = "Hydroponics Ring", Description = "Grows the station's food", Parent = station };
            StoryLocation trench = new StoryLocation { Name = "The Trench", Description = "The seafloor outside, where the signal comes from" }; // no parent: outside the station
            StoryLocation halcyon = new StoryLocation { Name = "Halcyon Platform", Description = "The surface platform" };

            story.Locations.Add(station);
            story.Locations.Add(commandDeck);
            story.Locations.Add(recordingBooth);
            story.Locations.Add(hydroponics);
            story.Locations.Add(trench);
            story.Locations.Add(halcyon);

            // ---------------- TAGS (created once in story.Tags) ----------------
            Tag needsWork = Story.CreateTag(story, "needs-work", "#E5533D");       // red
            Tag foreshadowing = Story.CreateTag(story, "foreshadowing", "#2F80ED"); // blue
            Tag safeZone = Story.CreateTag(story, "safe-zone", "#27AE60");          // green
            Tag danger = Story.CreateTag(story, "danger", "#F2994A");               // orange

            commandDeck.Tags?.Add(safeZone);
            hydroponics.Tags?.Add(safeZone);
            trench.Tags?.Add(danger);
            trench.Tags?.Add(foreshadowing);

            // ---------------- CHARACTERS ----------------
            // his home AND his place of death point to the same location
            Character grint = new Character
            {
                Name = "Tobias Grint",
                Age = 51,
                Role = CharacterRole.Supporting,
                Occupation = "Station commander",
                status = Status.MiddleClass,
                Personality = "stern",
                Sex = "Male",
                emotions = "tired, protective",
                Residency = commandDeck,
                DeathLocation = commandDeck,
                CharacterBackStory = "Has run Kestrel Deep for twelve years and lost crew before. He will not lose them again."
            };
            grint.CharactersGoals.Add("Keep the crew alive");
            grint.Likes.Add("different types of food");
            grint.Dislikes.Add("Lazy People");
            story.Characters.Add(grint);

            Character momohiko = new Character
            {
                Name = "Momohiko Hayakawa",
                Age = 25,
                Role = CharacterRole.Supporting,
                Occupation = "Service engineer",
                status = Status.MiddleClass,
                Personality = "cheerful",
                Sex = "Male",
                emotions = "curious",
                Residency = commandDeck,
                BirthLocation = commandDeck,
                DeathLocation = commandDeck,
                CharacterBackStory = "Born on the station. Knows every pipe and cable by heart."
            };
            momohiko.Likes.Add("Strawberry ice cream");
            momohiko.Likes.Add("ponies");
            momohiko.Likes.Add("old maps");
            momohiko.Likes.Add("artifacts");
            momohiko.Dislikes.Add("rudeness");
            momohiko.Dislikes.Add("arrogance");
            momohiko.CharactersGoals.Add("Fix the station's failing pumps");
            story.Characters.Add(momohiko);

            Character momone = new Character
            {
                Name = "Momone Genso",
                Age = 22,
                Role = CharacterRole.Unknown, // role not decided yet
                Occupation = "Musician",
                status = Status.MiddleClass,
                Personality = "dreamy",
                Sex = "Female",
                Residency = recordingBooth,
                BirthLocation = recordingBooth,
                DeathLocation = commandDeck,
                CharacterBackStory = "Records the station's ambient sounds for her music. She is the first to notice that the signal has a melody."
            };
            momone.Likes.Add("Guitars");
            momone.Likes.Add("budgies");
            momone.CharactersGoals.Add("Finish the song in the static");
            momone.Tags.Add(needsWork);
            story.Characters.Add(momone);

            Character anya = new Character
            {
                Name = "Anya Reyes",
                Age = 34,
                Role = CharacterRole.Protagonist,
                Occupation = "Marine geologist",
                status = Status.MiddleClass,
                Personality = "stoic",
                Height = "170 cm",
                Weight = "60 kg",
                Sex = "Female",
                emotions = "calm, driven",
                Residency = hydroponics,
                BirthLocation = hydroponics, // same object as her home
                CharacterBackStory = "A geologist who grew up on the station and came back after her father's expedition vanished in the trench. "
                                   + "She is the only one who has read his old dive notes, and she suspects the company never told the crew the whole story."
            }; // long backstory on purpose, to test how the UI handles long text
            anya.Likes.Add("deep water");
            anya.Likes.Add("old maps");
            anya.Dislikes.Add("corporate liaisons");
            anya.CharactersGoals.Add("Find the source of the signal");
            anya.CharactersGoals.Add("Learn what happened to her father");
            anya.Tags.Add(foreshadowing);
            story.Characters.Add(anya);

            Character kade = new Character
            {
                Name = "Dr. Samuel Kade",
                Age = 45,
                Role = CharacterRole.Antagonist,
                Occupation = "Corporate liaison",
                status = Status.Rich,
                Personality = "Arrogant",
                Sex = "Male",
                emotions = "smiling, cold",
                Residency = halcyon,
                CharacterBackStory = "Sent by the company with sealed orders."
            };
            kade.Dislikes.Add("questions");
            kade.CharactersGoals.Add("Keep the first expedition a secret");
            kade.Tags.Add(needsWork);
            kade.Tags.Add(danger);
            story.Characters.Add(kade);

            // the "unknown" test case: no age, unknown role and status, no likes, no goals, no tags
            Character choir = new Character
            {
                Name = "The Choir",
                Role = CharacterRole.Unknown,
                status = Status.Unknown,
                Occupation = "Entity",
                Residency = trench,
                CharacterBackStory = "Something in the trench that sings."
            };
            story.Characters.Add(choir);

            // ---------------- PLOT (beginning, middle, end) ----------------
            story.Plot.Beginning = "A strange signal reaches Kestrel Deep on the night shift.\nMomone hears a melody hidden in it.\n";
            story.Plot.Middle = "Kade arrives with sealed orders.\nThe hydroponics ring floods and the crew nearly loses its food.\n";
            story.Plot.Climax = "Kade locks the station down and Grint dies on the Command Deck.\nAnya and Momone dive into the trench.\n";
            story.Plot.Ending = "The crew holds a memorial on the Halcyon Platform.\n";
            story.Plot.PossibleFillers = "A blackout during a storm.\nMomohiko's ice cream supply runs out.\n";
            story.Plot.PlotPrgression = "Momone's music links the signal to the first crew.\n";

            // ---------------- EVENTS (in story order) ----------------
            Events signal = new Events
            {
                Order = 1,
                Title = "Signal Detected",
                Type = EventType.Incident,
                Phase = StoryPhase.Setup,
                Description = "The Command Deck picks up a repeating signal from the trench."
            };
            signal.CharactersInvolvedInEvent.Add(grint);
            signal.CharactersInvolvedInEvent.Add(anya);
            signal.LocationOfEvent.Add(commandDeck);
            signal.Tags.Add(foreshadowing);

            Events song = new Events
            {
                Order = 2,
                Title = "The Song in the Static",
                Type = EventType.SmallInteractions,
                Phase = StoryPhase.Setup,
                Description = "Momone plays the signal for Momohiko and hears a melody."
            };
            song.CharactersInvolvedInEvent.Add(momone);
            song.CharactersInvolvedInEvent.Add(momohiko);
            song.LocationOfEvent.Add(recordingBooth);
            song.CausedBy.Add(signal);
            song.Tags.Add(foreshadowing);

            Events liaison = new Events
            {
                Order = 3,
                Title = "The Liaison Arrives",
                Type = EventType.SmallInteractions,
                Phase = StoryPhase.RisingAction,
                Description = "Kade comes down from the surface and takes over."
            };
            liaison.CharactersInvolvedInEvent.Add(kade);
            liaison.CharactersInvolvedInEvent.Add(grint);
            liaison.LocationOfEvent.Add(halcyon);      // two locations: he starts on the surface...
            liaison.LocationOfEvent.Add(commandDeck);  // ...and ends on the Command Deck
            liaison.CausedBy.Add(signal);

            Events breach = new Events
            {
                Order = 4,
                Title = "Hydroponics Breach",
                Type = EventType.Crisis,
                Phase = StoryPhase.RisingAction,
                Description = "The hydroponics ring floods."
            };
            breach.CharactersInvolvedInEvent.Add(momohiko);
            breach.CharactersInvolvedInEvent.Add(anya);
            breach.LocationOfEvent.Add(hydroponics);
            breach.CausedBy.Add(liaison);
            breach.Tags.Add(danger);

            Events lockdown = new Events
            {
                Order = 5,
                Title = "Lockdown",
                Type = EventType.Crisis,
                Phase = StoryPhase.Climax,
                Description = "Kade seals the station. Grint dies trying to open it."
            };
            lockdown.CharactersInvolvedInEvent.Add(kade);
            lockdown.CharactersInvolvedInEvent.Add(grint);
            lockdown.CharactersInvolvedInEvent.Add(momohiko);
            lockdown.LocationOfEvent.Add(commandDeck);
            lockdown.CausedBy.Add(breach);
            lockdown.Tags.Add(danger);

            Events contact = new Events
            {
                Order = 6,
                Title = "Contact in the Trench",
                Type = EventType.BigEvent,
                Phase = StoryPhase.Climax,
                Description = "Anya and Momone meet the Choir."
            };
            contact.CharactersInvolvedInEvent.Add(anya);
            contact.CharactersInvolvedInEvent.Add(momone);
            contact.CharactersInvolvedInEvent.Add(choir);
            contact.LocationOfEvent.Add(trench);
            contact.CausedBy.Add(song);     // two causes
            contact.CausedBy.Add(lockdown);

            Events memorial = new Events
            {
                Order = 7,
                Title = "Memorial on the Surface",
                Type = EventType.Celebration,
                Phase = StoryPhase.Resolution,
                Description = "The survivors remember Grint."
            };
            memorial.CharactersInvolvedInEvent.Add(anya);
            memorial.CharactersInvolvedInEvent.Add(momone);
            memorial.CharactersInvolvedInEvent.Add(momohiko);
            memorial.LocationOfEvent.Add(halcyon);
            memorial.CausedBy.Add(contact);

            story.Events.Add(signal);
            story.Events.Add(song);
            story.Events.Add(liaison);
            story.Events.Add(breach);
            story.Events.Add(lockdown);
            story.Events.Add(contact);
            story.Events.Add(memorial);

            // ---------------- PLOT TWISTS (point to events that already exist) ----------------
            PlotTwist companyKnew = new PlotTwist
            {
                Description = "Kade's company found the Choir years ago and abandoned the first crew.",
                RevealEvent = lockdown,
                Tags = new List<Tag>() // PlotTwist.Tags has no starting value yet, so it is created here
            };
            companyKnew.ForeshadowEvents.Add(liaison);
            companyKnew.CharatersInPlotTwist.Add(kade);
            companyKnew.CharatersInPlotTwist.Add(grint);
            companyKnew.WhereThePlotTwistHappens.Add(commandDeck);
            story.Plot.PlotTwists.Add(companyKnew);

            PlotTwist choirIsCrew = new PlotTwist
            {
                Description = "The Choir is the first crew, transformed. The signal is their song.",
                RevealEvent = contact,
                Tags = new List<Tag>()
            };
            choirIsCrew.ForeshadowEvents.Add(signal);
            choirIsCrew.ForeshadowEvents.Add(song);
            choirIsCrew.CharatersInPlotTwist.Add(choir);
            choirIsCrew.CharatersInPlotTwist.Add(momone);
            choirIsCrew.WhereThePlotTwistHappens.Add(trench);
            choirIsCrew.Tags.Add(foreshadowing);
            story.Plot.PlotTwists.Add(choirIsCrew);

            // ---------------- RELATIONSHIPS ----------------
            story.Relationships.Add(new Relationship { From = grint, To = momohiko, Type = RelationshipType.Mentor, Description = "taught him to run the station" });
            story.Relationships.Add(new Relationship { From = anya, To = momone, Type = RelationshipType.Friend, Description = "trusts her ear" });
            story.Relationships.Add(new Relationship { From = kade, To = grint, Type = RelationshipType.Employer, Description = "outranks him" });
            story.Relationships.Add(new Relationship { From = momone, To = choir, Type = RelationshipType.Family, Description = "her mother was in the first crew", IsSecret = true });

            // ---------------- ITEMS (clues) ----------------
            story.Items.Add(new StoryItem { Name = "Signal recording", Description = "A tape of the melody", Owner = momone, Location = recordingBooth });
            story.Items.Add(new StoryItem { Name = "Sealed orders", Description = "The company's instructions", Owner = kade, Location = halcyon });
            story.Items.Add(new StoryItem { Name = "Command key", Description = "Opens the lockdown doors", Owner = grint, Location = commandDeck });
            story.Items.Add(new StoryItem { Name = "First crew's dive log", Description = "Found in the trench", Location = trench }); // no owner

            return story;
        }
    }
} 