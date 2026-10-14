using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class Character
    {
        public List<Tag>? Tags { get; set; }
        private string? _characterBackStory;

        public CharacterRole Role { get; set; }
        public List<string> CharactersGoals { get; set; } = new List<string>();

        public string? Occupation { get; set; }
        public string? Personality { get; set; }
        public string? Weight { get; set; }

        public string? Name { get; set; }
        public string? Height { get; set; }
        public int? Age { get; set; }

        public string? Sex { get; set; }
        public string? Race { get; set; }
        public StoryLocation? Residency { get; set; } // where character lives 
        public string? emotions { get; set; }

        public StoryLocation? BirthLocation { get; set; } // where the character was born 
        public StoryLocation? DeathLocation { get; set; } // where tghe charcater may die

        public Status status { get; set; } // economic Status of characters
        public List<string> Likes { get; set; } = new List<string>();
        public List<string> Dislikes { get; set; } = new List<string>();

        public string CharacterBackStory // a small back story for characters
        {
            get { return _characterBackStory; }
            set { _characterBackStory = value; }
        }

        // Character.Name = new Charcter();
    }
    public enum CharacterRole { Unknown, Protagonist, Antagonist, Mentor, Supporting, Minor }
    public enum Status { Unknown, Poor, PoorMiddleClass, MiddleClass, UpperMiddleClass, Rich, Wealthy }
}
