using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class UiMethods
    {
        public static void UserGreeting()
        {
            Console.WriteLine("Welcome to StoryOrganizer");
        }
        public static void PlotUserPrompt()
        {
            Console.WriteLine("Create Some Ideas for the story plot");
        }

        public static int UserModeSelection() // used for Mode selection 
        {
            Console.WriteLine("\nCreate a Story Selection Mode");
            // might have to use the try catch method just incase the exception us Unhandled 

            Console.WriteLine("1: Brain Dump\n2: Create the Plot\n3: Tags\n4: Create a Character");

            int UserModeSelection = Convert.ToInt32(Console.ReadLine());

            while (!int.TryParse(Console.ReadLine(), out UserModeSelection) ||
                UserModeSelection < Constants.BRAIN_DUMP_MODE_SELECTION ||
                UserModeSelection > Constants.CREATING_CHARACTER_MODE)
            {
                Console.WriteLine($"This is not a valid selection. Please enter a number within" +
                    $" the menu from {Constants.BRAIN_DUMP_MODE_SELECTION}" +
                    $" to {Constants.CREATING_CHARACTER_MODE}");
            }
            Console.WriteLine($" You Have selected {UserModeSelection}");
            return UserModeSelection;
        }


        public static int ValidateUserStorySelection()
        {
            int userChoice;
            bool isTheInputValid = false;
            do
            {
                string inVoluntaryInput = Console.ReadLine();
                if (int.TryParse(inVoluntaryInput, out userChoice))
                {
                    if (userChoice == Constants.BRAIN_DUMP_MODE_SELECTION)
                    {
                        Console.WriteLine($"You have selected {userChoice}");
                        isTheInputValid = true;
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid selection. Please try again");
                    }

                    if (userChoice == Constants.CREATING_PLOT_MODE)
                    {
                        Console.WriteLine($"You have selected {userChoice}");
                        isTheInputValid = true;
                    }
                    else
                    {
                        Console.WriteLine("This is not a vaild selection. PLease try again");
                    }

                    if (userChoice == Constants.CREATING_TAGS_ID_CARDS)
                    {
                        Console.WriteLine($"You have selected {userChoice}");
                        isTheInputValid = true;
                    }
                    else
                    {
                        Console.WriteLine("This is not a vaild selection. PLease try again");
                    }
                }

            } while (!isTheInputValid);
            return userChoice;
        }
        public static void ClearUserEntry()
        {
            Console.Clear();
        }
        public static string AskUserAboutIdea()
        {
            Console.WriteLine("What Idea(s) would you like to put out?\n");
            string? UserAnswer = Console.ReadLine();
            return UserAnswer;
        }

        public static void AskingUserToCreateTags()
        {
            Console.WriteLine("Please Create a Tag for oraganisation purposes ");
            // wondering if I should place tag objs in here?
        }
        public static int SelectOrganizerMode()
        {
            int UserInput = 0;
            return UserInput;
        }

        public static char AskingUserToAddAags()
        {
            Console.WriteLine("Do you want to add a Tag?");
            char userSelection = 'a';
            return userSelection;
        }


        // might use this for mode when constructing story user mode
        public static int ValidateSelectionMode(int userSelection)
        {
            bool isUserSelectionValid = false;
            do
            {
                if (userSelection != Constants.BRAIN_DUMP_MODE_SELECTION && userSelection != Constants.CREATING_PLOT_MODE
                    && userSelection != Constants.CREATING_TAGS_ID_CARDS)
                {
                    Console.WriteLine($"This {userSelection} is not the correct choice, please choose from the list\n");
                    //here add the list (subject to change)
                }
                else
                    isUserSelectionValid = true;
            }
            while (!isUserSelectionValid);
            return userSelection;
        }
        // both of these are linked together 
        public static int PlotModeSelection()
        {
            Console.WriteLine("\nWhich part of the plot do you wnat to work on?");
            Console.WriteLine("1: Beginning\n2: Middle\n 3: Ending\n4: Climax\n5: Plot Twist\n6: Possible Fillers\n7: Plot Progression\n0: Done");
            int userSelection;
            while (!int.TryParse(Console.ReadLine(), out userSelection) || userSelection < Constants.PLOT_DONE ||
                    userSelection > Constants.PLOT_PROGRESSION_MODE)
            {
                Console.WriteLine("This is not a valid selection. Please enter a number from 0 to 7 ");
            }
            return userSelection;
        }

        public static string CollectPlotSection(string sectionName)
        {
            string text = "";
            bool isUserDone = false;
            while (!isUserDone)
            {
                Console.WriteLine($"Write some ideas for the {sectionName}:");
                text += Console.ReadLine() + "\n"; // added += because the when an idea is placed it will not get replaced 

                Console.WriteLine($"Are you done or statisfied with what you ahev for {sectionName} (Y/N)");
                isUserDone = Logic.ValidateUserAnswerToYesNo() == Constants._YES;
                Console.WriteLine();
            }
            return text;
        }

        // prints every part of the plot so the user can see what was stored
        public static void DisplayPlot(PlotSystem plot)
        {
            Console.WriteLine("\n===== Your Plot =====");
            Console.WriteLine($"Beginning:\n{plot.Beginning}");
            Console.WriteLine($"Middle:\n{plot.Middle}");
            Console.WriteLine($"Ending:\n{plot.Ending}");
            Console.WriteLine($"Climax:\n{plot.Climax}");
            Console.WriteLine($"Possible Fillers:\n{plot.PossibleFillers}");
            Console.WriteLine($"Plot Progression:\n{plot.PlotPrgression}");
            Console.WriteLine($"Plot Twists ({plot.PlotTwists.Count}):");

            for (int i = 0; i < plot.PlotTwists.Count; i++)
            {
                Console.WriteLine($" {i + 1}. {plot.PlotTwists[i].Description}");
            }
        }
        public static void AskIfUserIsDoneQuestion()
        {
            Console.WriteLine("Is user Done Brainstroming?\nSelect Y/N\n");
        }

        // displays what the user has placed in userAnswer
        public static void DisplayUserAnswer(string userAnswer)
        {
            Console.WriteLine(userAnswer);
        }
        //goals for the character... will put this into another method
        public static string CharacterGoalInput()
        {
            string mainCharacterGoal = "";
            return mainCharacterGoal;
        }
        //used for age of character
        public static int NumberedUserInput()
        {
            int userInput = 0;
            return userInput;
        }

        public static char UserSelectionChar()
        {
            char userSelection = Console.ReadKey().KeyChar;
            return userSelection;
        }

        //used to display categories to the user.
        public static void DisplayCategories()
        {
            Console.WriteLine("Select your genre.");

            StoryCategory.storyCategories.Add("A: fantasy");
            StoryCategory.storyCategories.Add("B: SCI-Fi");
            StoryCategory.storyCategories.Add("C: True Story");
            StoryCategory.storyCategories.Add("D: Horror");

            foreach (string item in StoryCategory.storyCategories)
            {
                Console.WriteLine(item); // creates the list is displayed to the user
            }
        }

        // this is the DisplayCategories() for the user 
        public static void PrintWhatTheUserSelected(char userInput)
        {
            switch (userInput)
            {
                case Constants.A_SELECTION:
                    Console.WriteLine($"You have selected : {userInput}: Fantasy");

                    break;

                case Constants.B_SELECTION:
                    Console.WriteLine($"You have selected {userInput}: SCI-FI");

                    break;

                case Constants.C_SELECTION:
                    Console.WriteLine($"You have selected {userInput}: True Story");

                    break;
                case Constants.D_SELECTION:
                    Console.WriteLine($"You have selected {userInput}: Horror");

                    break;

                default:
                    Console.WriteLine("Invalid selection.");

                    break;
            }
        }

        public static int GetTheUserModeSelection(int userInput)
        {
            Console.WriteLine("Please Select which of the Following choices:\nBeginning Mode\n Middle Mode\nEndMode\nClimax");

            switch (userInput)
            {
                case Constants.BEGINNING_MODE:
                    Console.WriteLine($"You have selected:{userInput}: Beginning Mode");

                    break;

                case Constants.MIDDLE_MODE:
                    Console.WriteLine($"You have selected:{userInput}:Middle Mode");

                    break;

                case Constants.END_MODE:
                    Console.WriteLine($"You have selected:{userInput}:End Mode");

                    break;
                case Constants.CLIMAX_MODE:
                    Console.WriteLine($"You have selected:{userInput}: Climax Mode");
                    break;

                default:
                    Console.WriteLine("Invaild Selection");

                    break;
            }
            return userInput;
        }
        public static string SelectingCategoryforLoop()
        {
            return string.Empty;
        }

        //BrainDumpManager accessUserIdeaList = new BrainDumpManager(); // object of BrainDumpManager
        //BrainStormDump IdeaDump = new BrainStormDump(); //object of BrainStormDump

        public static void DisplayingTheBrainDumps(BrainDumpManager dumpManager)
        {
            int indexedNumber = 1;
            var dumps = dumpManager.GetList();

            for (int i = 0; i < dumps.Count; i++)
            {
                var dump = dumps[i];
                Console.WriteLine($"(title)Idea{indexedNumber:D2}:");
                for (int j = 0; j < dump.DumpArea.Count; j++)
                {
                    Console.WriteLine($" - {dump.DumpArea[j]}");
                }
                indexedNumber++;
            }
        }
        public static Character CharacterDevelopmentMode()
        {
            Character newCharacter = new Character();

            Console.WriteLine("Create a Character!");
            Console.WriteLine("What is the Character's Name");
            newCharacter.Name = Console.ReadLine();

            Console.WriteLine($"Create a backstory for {newCharacter.Name} ");
            newCharacter.CharacterBackStory = Console.ReadLine(); // creates a back story for the (main) character 


            return newCharacter;
        }
    }
}

