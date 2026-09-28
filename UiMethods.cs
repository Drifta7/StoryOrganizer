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

        //asking about what the idea the user will put out
        public static string AskUserAboutIdea()
        {
            Console.WriteLine("What Idea(s) would you like to put out?");
            string? UserAnswer = Console.ReadLine();
            return UserAnswer; // where the actual idea is stored
        }
        //generic question
        public static void AskIfUserIsDoneQuestion()
        {
            Console.WriteLine("Is user Done Brainstroming?");
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
                    Console.WriteLine($"You have selected : {userInput}");

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

        // this to fill out for the user characters and their attributes 
        public static void AskAboutMainCharacter()
        {
            Character characAtt = new Character(); // Character Class object
            Console.WriteLine("What is the age of the Main Character?");

            characAtt.CharacterAttributes.Add("Age");
            int age = NumberedUserInput();

            Console.WriteLine("What is the main character's Personality like?");

            characAtt.CharacterAttributes.Add("personailty");

            characAtt.CharacterAttributes.Add("height");

            characAtt.CharacterAttributes.Add("weight");
            characAtt.CharacterAttributes.Add("Occuaption");

            Console.WriteLine("What is the main Charcters goals");

            string goalInput = CharacterGoalInput();

            characAtt.CharactersGoals.Add($"{goalInput}");

            foreach (var item in characAtt.CharacterAttributes)
            {
                Console.WriteLine(item);
            }
        }

    }
}

