using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class UiMethods
    {
        static public void UserGreeting()
        {
            Console.WriteLine("Welcome to StoryOrganizer");
        }
        static string CharacterGoalInput()
        {
            string mainCharacterGoal = "";
            return mainCharacterGoal;
        }
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
        //refernece to UserSlection 
        public static char ValidateUserSelection()
        {
            char validateUserEntry = UserSelection();
            validateUserEntry = char.ToUpper(validateUserEntry); // makes the user entry letter uppercase
            return validateUserEntry;
        }



        //used to display categories to the user
        static public void DisplayCategories()
        {
            //StoryCategory category = new StoryCategory();
            StoryCategory.storyCategories.Add("fantacy");
            StoryCategory.storyCategories.Add("SCI-Fi");
            StoryCategory.storyCategories.Add("True Story");
            StoryCategory.storyCategories.Add("Horror");
            StoryCategory.storyCategories.Add("Anime"); // might change this.

            foreach (string item in StoryCategory.storyCategories)
            {
                Console.WriteLine(item); // creates the list is displayed to the user
            }
        }

        // this is the DisplayCategories() for the user 
        public static void PrintWhatTheUserSelected(int userInput)
        {
            switch (userInput)
            {
                case Constants.A_SELECTION:
                    Console.WriteLine($"You have selected {userInput}:");

                    break;

                case Constants.B_SELECTION:
                    Console.WriteLine($"You have selected {userInput}");

                    break;

                case Constants.C_SELECTION:
                    Console.WriteLine($"You have selected {userInput}");

                    break;
                case Constants.D_SELECTION:
                    Console.WriteLine($"You have selected {userInput}");

                    break;

                default:
                    Console.WriteLine("Invalid selection.");

                    break;
            }
        }

        public static void AskAboutMainCharacter()
        {
            Console.WriteLine("What is the age of the Main Character?");

            StoryCategory.mainCharcterAttibutes.Add("Age");
            int age = NumberedUserInput();

            Console.WriteLine("What is the main character's Personality like?");

            StoryCategory.mainCharcterAttibutes.Add("personailty");


            StoryCategory.mainCharcterAttibutes.Add("height");


            StoryCategory.mainCharcterAttibutes.Add("weight");
            StoryCategory.mainCharcterAttibutes.Add("Occuaption");

            Console.WriteLine("What is the main Charcters goals");

            string goalInput = CharacterGoalInput();

            StoryCategory.mainCharctersGoals.Add($"{goalInput}");

            foreach (var item in StoryCategory.mainCharcterAttibutes)
            {
                Console.WriteLine(item);
            }
        }

    }
}

