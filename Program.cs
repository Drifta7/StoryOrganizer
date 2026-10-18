
using System.ComponentModel;

namespace StoryOrganizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Story story = new Story(); // create an instance of the object for Story class
            bool isUserDoneBrainStorming = false;

            UiMethods.UserGreeting();
            UiMethods.DisplayCategories();

            char AnswerForCharacterSelection = Logic.ValidateUserSelectionInMenu(UiMethods.UserSelectionChar());

            Console.Clear();

            UiMethods.PrintWhatTheUserSelected(AnswerForCharacterSelection);

            // place the logic Method here 

            // here create a method that asked the question about the selection that the user picked
            //psudeoMethodHere();


            BrainStormDump idea = new BrainStormDump();
            BrainDumpManager passOn = new BrainDumpManager();

            int UserSelectionMode = UiMethods.UserModeSelection();

            if (UserSelectionMode == Constants.BRAIN_DUMP_MODE_SELECTION)
            {

                while (!isUserDoneBrainStorming)
                {
                    //Adds to the User Ideas to a list when Brainstorming
                    BrainStormDump dumpEntry = new BrainStormDump();

                    Logic.UserDrivenInputToClass(dumpEntry); // asks for ideas and stores them in dumpEntry

                    passOn.AddBrainDump(dumpEntry); // stores the finished batch
                    UiMethods.AskIfUserIsDoneQuestion();

                    char userYesOrNoAns = Logic.ValidateUserAnswerToYesNo();
                    UiMethods.ClearUserEntry();

                    isUserDoneBrainStorming = userYesOrNoAns == Constants._YES;
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
                int plotSelection = UiMethods.PlotModeSelection();
                while (plotSelection != Constants.PLOT_DONE)
                {
                    switch (plotSelection)
                    {
                        case Constants.BEGINNING_MODE:
                            story.Plot.Beginning += UiMethods.CollectPlotSection("beginning");

                            break;

                        case Constants.MIDDLE_MODE:
                            story.Plot.Middle += UiMethods.CollectPlotSection("middle");

                            break;

                        case Constants.END_MODE:
                            story.Plot.Ending += UiMethods.CollectPlotSection("ending");

                            break;

                        case Constants.CLIMAX_MODE:
                            story.Plot.Climax += UiMethods.CollectPlotSection("climax");
                            break;

                        case Constants.PLOT_TWIST_MODE:

                            PlotTwist twist = new PlotTwist(); // a NEW twist, owned by the plot's list
                            twist.Description = UiMethods.CollectPlotSection("plot twist");
                            story.Plot.PlotTwists.Add(twist);

                            break;

                        case Constants.POSSIBLE_FILLERS_MODE:
                            story.Plot.PossibleFillers += UiMethods.CollectPlotSection("possible fillers");

                            break;

                        case Constants.PLOT_PROGRESSION_MODE:
                            story.Plot.PlotPrgression += UiMethods.CollectPlotSection("plot progression");

                            break;
                    }

                    plotSelection = UiMethods.PlotModeSelection(); // back to the plot menu
                }

                UiMethods.DisplayPlot(story.Plot); // shows everything that was stored in the Story
            }

            if (UserSelectionMode == Constants.CREATING_TAGS_ID_CARDS)
            {
                Console.WriteLine(" 3rd Selection worked and this is the result ");
            }

            if (UserSelectionMode == Constants.CREATING_CHARACTER_MODE)
            {
                Character newCharacter = UiMethods.CharacterDevelopmentMode();
                story.Characters.Add(newCharacter); // the Story owns this character 

                Console.WriteLine($"\nChacactet in the story: {story.Characters.Count}");

                foreach (Character character in story.Characters)
                {
                    Console.WriteLine($"{character.Name}:{character.CharacterBackStory}");
                }

            }
            UiMethods.DisplayingTheBrainDumps(passOn);
        }
    }
}
