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

            // BrainStormDump UserIdeas = new BrainStormDump(); // for ideas

            //UserIdeas.DumpArea.Add(""); // where the user manually puts in ideas
            // how do you create a dyanamic list where the user adds as much ideas as they want?

            // this is where the user puts in their ideas that is save to a variable.
            //UiMethods.DisplayUserAnswer(idea.Content);

           

            while (!isUserDoneBrainStorming)
            {
                //Adds to the User Ideas to a list when Brainstorming



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

            foreach (var item in BrainDumpList)
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
