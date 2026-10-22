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

        public static int UserModeSelection() // used for Mode selection 
        {
            Console.WriteLine("\nCreate a Story Selection Mode");
            // might have to use the try catch method just incase the exception us Unhandled 

            Console.WriteLine("1: Brain Dump\n2: Create the Plot\n3: Tags\n4: Create a Character");

            int UserModeSelection;

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

        public static char AskingUserToAddAags()
        {
            Console.WriteLine("Do you want to add a Tag?");
            char userSelection = 'a';
            return userSelection;
        }
        public static char ValidateUserAnswerToYesNo()
        {
            bool isUserAnsEitherYOrN = false;
            char yesOrNoAnswer = char.ToUpper(Console.ReadKey().KeyChar);

            do
            {
                if (yesOrNoAnswer != Constants._YES && yesOrNoAnswer != Constants._NO)
                {
                    Console.WriteLine("this isn't the correct response, Please try again ");
                    yesOrNoAnswer = char.ToUpper(Console.ReadKey().KeyChar);
                }
                else
                    isUserAnsEitherYOrN = true;

            } while (!isUserAnsEitherYOrN);

            return yesOrNoAnswer;
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
                isUserDone = ValidateUserAnswerToYesNo() == Constants._YES;
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

        //BrainDumpManager accessUserIdeaList = new BrainDumpManager(); // object of BrainDumpManager
        //BrainStormDump IdeaDump = new BrainStormDump(); //object of BrainStormDump

        public static void DisplayingTheBrainDumps(IdeaCanvasManager dumpManager)
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
        public static Character CharacterDevelopmentMode(Story story)
        {
            Character newCharacter = new Character();
            Console.WriteLine("Create a Character!");

            Console.WriteLine("\nWhat is the Character's Name");
            newCharacter.Name = Console.ReadLine();

            newCharacter.Role = SelectFromEnum<CharacterRole>($"\nWhat role does {newCharacter.Name} play in the story?");

            Console.WriteLine($"Create a backstory for {newCharacter.Name} ");
            newCharacter.CharacterBackStory = Console.ReadLine(); // creates a back story for the (main) character 

            Console.WriteLine("What is the Age (leave blank if unknown)");
            int age;
            if (int.TryParse(Console.ReadLine(), out age))
            {
                newCharacter.Age = age;
            }

            Console.WriteLine("What is the characters Occupation?");
            newCharacter.Occupation = Console.ReadLine();

            newCharacter.status = SelectFromEnum<Status>($"\nWhat is {newCharacter.Name}'s economic status?");

            Console.WriteLine("What Type of Personality does the Character have? \ncheerful\ngloomy\nstoic\nArrogant\n...etc");
            newCharacter.Personality = Console.ReadLine();

            Console.WriteLine("What is the Height of The Character?");
            newCharacter.Height = Console.ReadLine();

            Console.WriteLine("How much does the character weigh?");
            newCharacter.Weight = Console.ReadLine();

            Console.WriteLine("What is the Sex of the Character?");
            newCharacter.Sex = Console.ReadLine();

            Console.WriteLine("What is the Character's Ethnicity? ");
            newCharacter.Race = Console.ReadLine();

            Console.WriteLine("What are the common emotion that the Character displays");
            newCharacter.emotions = Console.ReadLine();

            newCharacter.Likes.AddRange(CollectList($"What does {newCharacter.Name} like?"));
            newCharacter.Dislikes.AddRange(CollectList($"What does {newCharacter.Name} dislike?"));
            newCharacter.CharactersGoals.AddRange(CollectList($"What are {newCharacter.Name}'s goals?"));

            Console.WriteLine("Where does the character live? (Leave blank if unknown)");
            newCharacter.Residency = StoryCategory.FindOrCreateLocation(story, Console.ReadLine());

            Console.WriteLine("Where was the Character born? (Leave blank if unknown)");
            newCharacter.BirthLocation = StoryCategory.FindOrCreateLocation(story, Console.ReadLine());

            Console.WriteLine("Where does the character die? (Leave blank if unknown)");
            newCharacter.DeathLocation = StoryCategory.FindOrCreateLocation(story, Console.ReadLine());

            newCharacter.Tags.AddRange(CollectTags(story, newCharacter.Name ?? "this character"));

            return newCharacter;
        }
             
        // asks for tag names one per line; reuses tags the Story already has, creates (and colours) new ones
        public static List<Tag> CollectTags(Story story, string itemName)
        {
            List<Tag> chosenTags = new List<Tag>();
            Console.WriteLine($"Add tags to {itemName} (one per line, press Enter on an empty line when done)");

            string? tagName = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(tagName))
            {
                Tag? tag = Story.FindTag(story, tagName);
                if (tag == null)
                {
                    string color = SelectTagColor(tagName.Trim());
                    tag = Story.CreateTag(story, tagName, color);
                }
                else
                {
                    Console.WriteLine($"Using existing tag '{tag.Name}' ({tag.Color})");
                }

                if (!chosenTags.Contains(tag)) // don't add the same tag twice to one item
                {
                    chosenTags.Add(tag);
                }
                tagName = Console.ReadLine();
            }
            return chosenTags;
        }

        // asks the user to pick a colour for a new tag and returns it as a hex string
        public static string SelectTagColor(string tagName)
        {
            string[] colorNames = { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Grey" };
            string[] colorHex = { "#E5533D", "#F2994A", "#F2C94C", "#27AE60", "#2F80ED", "#9B51E0", "#808080" };

            Console.WriteLine($"'{tagName}' is a new tag. Pick a colour:");
            for (int i = 0; i < colorNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {colorNames[i]}");
            }

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > colorNames.Length)
            {
                Console.WriteLine($"This is not a valid selection. Please enter a number from 1 to {colorNames.Length}.");
            }
            return colorHex[choice - 1];
        }

        // shows every value of an enum as a numbered menu and returns the one the user picks (0 = Unknown)
        public static T SelectFromEnum<T>(string question) where T : struct, Enum
        {
            T[] options = Enum.GetValues<T>();
            Console.WriteLine(question);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i}: {options[i]}");
            }

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice >= options.Length)
            {
                Console.WriteLine($"This is not a valid selection. Please enter a number from 0 to {options.Length - 1}.");
            }
            return options[choice];
        }

        // collects items one per line, until the user presses Enter on an empty line
        public static List<string> CollectList(string question)
        {
            List<string> items = new List<string>();
            Console.WriteLine($"{question} (one per line, press Enter on an empty line when done)");

            string? item = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item.Trim());
                item = Console.ReadLine();
            }
            return items;
        }

        // prints everything stored about one character
        public static void DisplayCharacter(Character character)
        {
            Console.WriteLine($"\n===== {character.Name} =====");
            Console.WriteLine($"Role: {character.Role}");
            Console.WriteLine($"Age: {(character.Age.HasValue ? character.Age.ToString() : "unknown")}");
            Console.WriteLine($"Occupation: {character.Occupation}");
            Console.WriteLine($"Status: {character.status}");
            Console.WriteLine($"Personality: {character.Personality}");
            Console.WriteLine($"Height: {character.Height}   Weight: {character.Weight}");
            Console.WriteLine($"Sex: {character.Sex}   Ethnicity: {character.Race}");
            Console.WriteLine($"Emotions: {character.emotions}");
            Console.WriteLine($"Likes: {string.Join(", ", character.Likes)}");
            Console.WriteLine($"Dislikes: {string.Join(", ", character.Dislikes)}");
            Console.WriteLine($"Goals: {string.Join(", ", character.CharactersGoals)}");
            Console.WriteLine($"Lives in: {character.Residency?.Name ?? "unknown"}");
            Console.WriteLine($"Born in: {character.BirthLocation?.Name ?? "unknown"}");
            Console.WriteLine($"Dies in: {character.DeathLocation?.Name ?? "unknown"}");
            Console.WriteLine($"Backstory: {character.CharacterBackStory}");

            List<string> tagLabels = new List<string>();
            foreach (Tag tag in character.Tags)
            {
                tagLabels.Add($"{tag.Name} ({tag.Color})");
            }
            Console.WriteLine($"Tags: {string.Join(", ", tagLabels)}");
        }
    }
}

