using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class StoryLocation
    {
        public List<Tag>? Tags { get; set; } // tags for location(s)
       
        public string? Description { get; set; }

        public StoryLocation? Parent { get; set; }

        public string Name { get; set; } = String.Empty;
        
        private string? _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

    }
}
