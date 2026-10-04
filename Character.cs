using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class Character
    {
        public List<string> MainCharacter = new List<string>();
        public List<string> MainCharacters = new List<string>();

        public List<string> SupportingCast = new List<string>(); 
        public List<string> CharacterAttributes = new List<string>();
        public List<string> CharactersGoals = new List<string>();
        public string? characterAttributes { get; set; }
        public string? Name;
        public string? Height;
        public int? Age;
        public string? Residency;
        public string? emotions;
        // Character.Name = new Charcter();
    }
}
