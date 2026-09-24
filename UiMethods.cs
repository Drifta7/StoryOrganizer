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
        public static void UserGreeting()
        {
            Console.WriteLine("Welcome to StoryOrganizer");
        }

        public static string AskUserQuestion()
        {
            Console.WriteLine("What is your Idea that you like to put out?");
            string UserAnswer = Console.ReadLine();
            return UserAnswer;
        }

        public static void AskIfUserIsDoneQuestion()
        {
            Console.WriteLine("Is user Done Brainstroming?");
        }

        public static void DisplayUserAnswer(string userAnswer)
        {
            Console.WriteLine(userAnswer);
        }
        public static string CharacterGoalInput()
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
        public static void DisplayCategories()
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

            StoryCategory.mainCharcterAttributes.Add("Age");
            int age = NumberedUserInput();

            Console.WriteLine("What is the main character's Personality like?");

            StoryCategory.mainCharcterAttributes.Add("personailty");


            StoryCategory.mainCharcterAttributes.Add("height");


            StoryCategory.mainCharcterAttributes.Add("weight");
            StoryCategory.mainCharcterAttributes.Add("Occuaption");

            Console.WriteLine("What is the main Charcters goals");

            string goalInput = CharacterGoalInput();

            StoryCategory.mainCharctersGoals.Add($"{goalInput}");

            foreach (var item in StoryCategory.mainCharcterAttributes)
            {
                Console.WriteLine(item);
            }
        }

    }
}

