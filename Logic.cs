using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    internal class Logic
    {
        public static char ValidateUserSelectionInMenu(char validateUserEntry)
        {
            bool hasUserChoosenChar = false;
            char upperChar = char.ToUpper(validateUserEntry); // makes the user entry letter uppercase
            Console.WriteLine();// used to create another line 
            do
            {
                if (upperChar != Constants.A_SELECTION && upperChar != Constants.B_SELECTION
                   && upperChar != Constants.C_SELECTION && upperChar != Constants.D_SELECTION)
                {
                    Console.WriteLine("This isn't the correct entry please try again");
                    upperChar = char.ToUpper(Console.ReadKey().KeyChar); //  User re-entry 
                }
                else
                    hasUserChoosenChar = true;

            }
            while (!hasUserChoosenChar);
            return upperChar;
        }
        public static char ValidateUserSelection(char validateUserEntry)
        {
            char upperChar = char.ToUpper(validateUserEntry); // makes the user entry letter uppercase
            Console.WriteLine();// used to create another line 
            return upperChar;
        }
        // this allows the User to create as many ideas they want
        public static void UserDrivenInputToClass(IdeaCanvasDump dump) // <-------this method work great which will stay.
        {
            for (int i = 0; i < Constants.IDEA_COUNTER; i++)
            {
                dump.DumpArea.Add(UiMethods.AskUserAboutIdea()); // this places the Ideas into DumpArea
            }
        }
        // returns the location with this name from the Story, creating it (once) if it doesn't exist yet


        // creates a new tag once and adds it to the Story's master list

        //public static int AgeLogicCalculator(int input, int ConstantInput) // age less or equal to OR greater than
        //{
        //    int age = 0;
        //    age = input;

        //    if (input < ConstantInput)
        //    {

        //    }

        //    else if (input > ConstantInput)
        //    {
        //        add message from UiMethods?
        //    }

        //    else if (input == ConstantInput)
        //    {
        //        add message from UiMethods?
        //    }
        //    return age;
        //}
    }
}
