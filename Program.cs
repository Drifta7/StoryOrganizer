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

                    passOn.AddBrainDump(dumpEntry); // passOn object to acesse the AddBrainDump

                    UiMethods.AskIfUserIsDoneQuestion();
                    char userYesOrNoAns = Logic.ValidateUserAnswerToYesNo();
                    UiMethods.ClearUserEntry();
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

                // foreach loop displays the Users finished ideas
                foreach (var item in passOn.GetList())
                {
                    foreach (var List in item.DumpArea)
                    {
                        Console.WriteLine(List);
                    }
                }
            }


            if (UserSelectionMode == Constants.CREATING_PLOT_MODE)
            {
                bool isTheUserDoneWithBeginning = false;

                int var = UiMethods.PlotModeSelection();
                UiMethods.ValidatePlotSelection(var, Constants.BEGINNING_MODE);
                int switchSelection = UiMethods.GetTheUserModeSelection(var);

                if (var == Constants.BEGINNING_MODE)
                {
                    char userYesOrNoAns = Logic.ValidateUserAnswerToYesNo();
                    while (!isTheUserDoneWithBeginning)
                    {
                        UiMethods.PlotUserPrompt();

                        Plot PlotAccess = new Plot();
                        PlotAccess.Beginning = Console.ReadLine(); // where will this return to????

                        if (userYesOrNoAns == Constants._NO)
                        {
                            continue;
                        }
                        else if (userYesOrNoAns == Constants._YES)
                        {
                            isTheUserDoneWithBeginning = true;
                        }
                    }
                }

                if (var == Constants.MIDDLE_MODE)
                {
                    bool isUserDoneWithMiddle = false;
                    char userYesOrNo = Logic.ValidateUserAnswerToYesNo();
                    while (!isUserDoneWithMiddle)
                    {
                        UiMethods.PlotUserPrompt();
                        Plot PlotAccessMid = new Plot();
                        PlotAccessMid.Middle = Console.ReadLine();

                        if (userYesOrNo == Constants._NO)
                        {
                            continue;
                        }
                        else
                        {
                            isUserDoneWithMiddle = true;
                        }
                    }
                }
                if (var == Constants.END_MODE)
                {
                    bool isUserDoneWithEnding = false;
                    char userYesOrNo = Logic.ValidateUserAnswerToYesNo();
                    while (!isUserDoneWithEnding)
                    {
                        UiMethods.PlotUserPrompt();
                        Plot PlotAccessEnd = new Plot();
                        PlotAccessEnd.Ending = Console.ReadLine();

                        if (userYesOrNo == Constants._NO)
                        {
                            continue;
                        }
                        else
                        {
                            isUserDoneWithEnding = true;
                        }
                    }
                }

                if (var == Constants.CLIMAX_MODE)
                {
                    bool isUserDoneWithClimax = false;
                    char userYesOrNo = Logic.ValidateUserAnswerToYesNo();
                    while (!isUserDoneWithClimax)
                    {
                        UiMethods.PlotUserPrompt();
                        Plot PlotAccessClimax = new Plot();
                        PlotAccessClimax.Climax = Console.ReadLine();

                        if (userYesOrNo == Constants._NO)
                        {
                            continue;
                        }
                        else
                        {
                            isUserDoneWithClimax = false;
                        }
                    }
                }
                if (UserSelectionMode == Constants.CREATING_TAGS_ID_CARDS)
                {
                    Console.WriteLine(" 3rd Selection worked and this is the result ");
                }

                UiMethods.DisplayingTheBrainDumps(passOn);
                //UiMethods.AskAboutMainCharacter(); //not sure I want to call this method just yet
            }
        }
    }
}
