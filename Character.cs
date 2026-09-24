using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class Character
    {
        public List<string> SupportingCast = new List<string>(); 
        
        public string characterAttributes { get; set;}
        public string characterName { get; set;}

        public string Name;
        public string Height;
        public string Age;
        public string residency;

        // Character.Name = new Charcter();
    }
}
