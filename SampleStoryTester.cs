using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class SampleStoryTester
    {
        // this will be for to collect all the data points for the story 

        public static Story Create()
        {
            Story story = new Story();

            StoryLocation? commandDeck = StoryCategory.FindOrCreateLocation(story, "Command Deck");

            // create a character; his home AND his place of death to the same location and other personal info
            //enums at use
            Character grint = new Character
            {
                Name = "Tobias Grint",
                Age = 51,
                Role = CharacterRole.Supporting,
                Occupation = "Station commander",
                status = Status.MiddleClass,
                Residency = commandDeck,
                DeathLocation = commandDeck
            };
            grint.CharactersGoals.Add("Keep the crew alive");

            story.Characters.Add(grint);
            grint.Likes.Add("different types of food");
            grint.Dislikes.Add("Lazy People");


            Character momohiko = new Character
            {
                Name = "Momohiko Hayakawa",
                Age = 25,
                Role = CharacterRole.Supporting,
                Occupation = "service engineer",
                status = Status.MiddleClass,
                Residency = commandDeck,
                BirthLocation = commandDeck,
                DeathLocation = commandDeck
            };

            momohiko.Likes.Add("Starwberry Ice cream, ponies");
            momohiko.Likes.Add("old Maps, artifacts");
            momohiko.Dislikes.Add("rudeness, arrogance");

            return story;
        }

    }





    // needs Beginning ,middle and end attibutes 
    // characters ,location   and the other classes 
}

