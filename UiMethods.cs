using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    public class UiMethods
    {
        static public void UserGreeting()
        {
            Console.WriteLine("Welcome to StoryOrganizer");
        }

        static public string AskUserQuestion()
        {
            Console.WriteLine("What is your Idea that you like to put out?");
            string UserAnswer = Console.ReadLine();
            return UserAnswer;
        }

        static public void DisplayUserAnswer(string userAnswer)
        {
            Console.WriteLine(userAnswer);
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
        //used to select DisplayCatergory number 
        public static char ValidateUserSelection(char validateUserEntry)
        {
            char upperChar = char.ToUpper(validateUserEntry); // makes the user entry letter uppercase
            return upperChar;
        }

        //used to display categories to the user.
        static public void DisplayCategories()
        {
            Console.WriteLine("Select your genre.");

            StoryCategory.storyCategories.Add("A: fantacy");
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
                    Console.WriteLine($"You have selected : {userInput}:");

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

