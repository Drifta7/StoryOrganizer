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

            // idea.Content = " the motorcycle has been stolen, and it was her fathers ride"; // example

            // Console.WriteLine(idea.Content);



            // this is where the user puts in their ideas that is save to a variable.


            // BrainStormDump UserIdeas = new BrainStormDump(); // for ideas


            //UserIdeas.DumpArea.Add(""); // where the user manually puts in ideas
            // how do you create a dyanamic list where the user adds as much ideas as they want?

            UiMethods.DisplayUserAnswer(idea.Content);

            while (!isUserDoneBrainStorming)
            {
                //Adds to the User Ideas to a list when Brainstorming
                List<BrainStormDump> BrainDumpList = new List<BrainStormDump>(); // creates new list set named BrainDumpList
                {
                    BrainStormDump BrainDumpEntry = new BrainStormDump(); //object/blueprint of BrainStromDump Class
                    BrainDumpEntry.DumpArea.Add(UiMethods.AskUserAboutIdea()); //adds AskUserAboutIdea return value to DumpArea in the class
                    BrainDumpList.Add(BrainDumpEntry); // adds User Entry to the BrainDumplist
                }

                UiMethods.AskIfUserIsDoneQuestion(); // this is just a display question
                char userYesOrNoAns = Logic.ValidateUserAnswerToYesNo(); // where the User anwsers the question with Y or N 

                if (userYesOrNoAns == Constants._NO)
                {
                    string userAnswer = UiMethods.AskUserAboutIdea(); // this is where the user types up the potential idea dump, 
                    idea.Content = userAnswer;
                }

                else if (userYesOrNoAns == Constants._YES)
                {
                    isUserDoneBrainStorming = true;
                    //user Exits the session 
                }
            }

            UiMethods.AskAboutMainCharacter(); //not sure I want to call this method just yet
        }
    }
}
