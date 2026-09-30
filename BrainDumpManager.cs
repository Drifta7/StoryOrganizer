using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class BrainDumpManager
    {
        private List<BrainStormDump> BrainDumpList = new List<BrainStormDump>();   // creates new list set named BrainDumpList

        public void AddBrainDump(BrainStormDump dump)
        {
            BrainStormDump BrainDumpEntry = new BrainStormDump(); //object/blueprint of BrainStromDump Class
            
            BrainDumpEntry.DumpArea.Add(UiMethods.AskUserAboutIdea()); //adds AskUserAboutIdea return value to DumpArea in the class
            BrainDumpList.Add(BrainDumpEntry); // adds User Entry to the BrainDumplist
        }

        public List<BrainStormDump> GetList() // get the list from passOn object in that Main()
        {
            return BrainDumpList;
        }
    }
}
