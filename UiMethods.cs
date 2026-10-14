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
            Console.WriteLine(" Create a Story Selection Mode");
            int UserModeSelection = Convert.ToInt32(Console.ReadLine());
            return UserModeSelection;
        }

        public static void AskUserIfBeginningDone()
        {
            Console.WriteLine("Are you done or satisfied with what you have for the beginning? ");
        }
        public static void AskUserIfMiddleDone()
        {
            Console.WriteLine("Are you done or satisfied with what you have for the Middle? ");
        }

        public static void AskUserIfEndingDone()
        {
            Console.WriteLine("Are you done or satisfied with what you have for the Ending? ");
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
            int userSelection = Convert.ToInt32(Console.ReadLine());
            return userSelection;
        }
        // linked to the method above
        public static int ValidatePlotSelection(int PlotModeSelection, int ConstSelection)
        {
            bool isPlotSelectionValid = false;
            do
            {
                if (PlotModeSelection == ConstSelection) // 
                {
                    Console.WriteLine($" you have selected: {PlotModeSelection}");
                }
                else
                {
                    Console.WriteLine("This is not the correct Selection ");
                }
            }
            while (!isPlotSelectionValid);
            return PlotModeSelection;
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

        public static char UserSelection()
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


        // this to fill out for the user characters and their attributes 
        public static void AskAboutMainCharacter()
        {
            Character characAtt = new Character(); // Character Class object
            Console.WriteLine("What is the age of the Main Character?");

            // characAtt.CharacterAttributes.Add("Age");
            int age = NumberedUserInput();

            Console.WriteLine("What is the main character's Personality like?");

            // characAtt.CharacterAttributes.Add("personailty");

            // characAtt.CharacterAttributes.Add("height");

            // characAtt.CharacterAttributes.Add("weight");
            //  characAtt.CharacterAttributes.Add("Occuaption");

            Console.WriteLine("What is the main Charcters goals");

            string goalInput = CharacterGoalInput();

            characAtt.CharactersGoals.Add($"{goalInput}");

            //foreach (var item in characAtt.CharacterAttributes)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}

