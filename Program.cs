using System.Net.NetworkInformation;

namespace StoryOrganizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isUserDoneBrainStorming = false;

            UiMethods.UserGreeting();
            UiMethods.DisplayCategories();

            char AnswerForCharacterSelection = Logic.ValidateUserSelectionInMenu(UiMethods.UserSelection());

            Console.Clear();

            UiMethods.PrintWhatTheUserSelected(AnswerForCharacterSelection);

            // here create a method that asked the question about the selection that the user picked
            //psudeoMethodHere();

            BrainStormDump idea = new BrainStormDump();
            BrainDumpManager passOn = new BrainDumpManager();

            int UserSelectionMode = UiMethods.UserModeSelection();

            if (UserSelectionMode == Constants.BRAIN_DUMP_MODE_SELECTION)
            {
                int ideaCounter = 0;
                while (!isUserDoneBrainStorming)
                {
                    //Adds to the User Ideas to a list when Brainstorming
                    BrainStormDump dumpEntry = new BrainStormDump();

                    passOn.AddBrainDump(dumpEntry);

                    UiMethods.AskIfUserIsDoneQuestion();
                    char userYesOrNoAns = Logic.ValidateUserAnswerToYesNo();

                    if (userYesOrNoAns == Constants._NO)
                    {
                        continue;
                    }

                    else if (userYesOrNoAns == Constants._YES)
                    {
                        isUserDoneBrainStorming = true;
                        //user Exits the session 
                    }
                    while (ideaCounter == Constants.IDEA_COUNTER)
                    {
                        ideaCounter++;
                    }
                }

                foreach (var item in passOn.GetList())
                {
                    foreach (var List in item.DumpArea)
                    {
                        Console.WriteLine(List);
                    }
                }
            }
            //if (UserSelectionMode == Constants.CREATING_PLOT_MODE) { }
            //if (UserSelectionMode == Constants.BRAIN_DUMP_MODE_SELECTION) { }

            UiMethods.DisplayingTheBrainDumps(passOn);
            //UiMethods.AskAboutMainCharacter(); //not sure I want to call this method just yet
        }
    }
}
