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

            BrainStormDump idea = new BrainStormDump();

            BrainDumpManager passOn = new BrainDumpManager();

            while (!isUserDoneBrainStorming)
            {
                //Adds to the User Ideas to a list when Brainstorming
                BrainStormDump dumpEntry = new BrainStormDump();

                dumpEntry.DumpArea.Add(UiMethods.AskUserAboutIdea());

                passOn.AddBrainDump(dumpEntry);

                UiMethods.AskIfUserIsDoneQuestion();
                char userYesOrNoAns = Logic.ValidateUserAnswerToYesNo();

                if (userYesOrNoAns == Constants._NO)
                {
                    continue;
                    //string userAnswer = UiMethods.AskUserAboutIdea();  
                    //idea.Content = userAnswer;// this is where the user types up the potential idea dump,
                }

                else if (userYesOrNoAns == Constants._YES)
                {
                    isUserDoneBrainStorming = true;
                    //user Exits the session 
                }
            }

            foreach (var item in passOn.GetList())
            {
                foreach (var List in item.DumpArea)
                {
                    Console.WriteLine(List);
                }
            }

            //UiMethods.AskAboutMainCharacter(); //not sure I want to call this method just yet
        }
    }
}
