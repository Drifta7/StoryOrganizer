using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class IdeaCanvasManager
    {
        private List<IdeaCanvasDump> UserIdeasAreaList = new List<IdeaCanvasDump>();   // creates new list set named BrainDumpList

        public void AddIdeaCanvasDump(IdeaCanvasDump dump)
        {
            UserIdeasAreaList.Add(dump); // adds User Entry to the BrainDumplist
        }

        public List<IdeaCanvasDump> GetList() // get the list from passOn object in that Main()
        {
            return UserIdeasAreaList;
        }
    }
}
