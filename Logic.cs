using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    internal class Logic
    {
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

        public static int AgeLogicCalculator(int input, int ConstantInput) // age less or equal to OR greater than
        {
            int age = 0;
            age = input;

            if (input < ConstantInput)
            {

            }

            else if (input > ConstantInput)
            {
                // add message from UiMethods?
            }

            else if (input == ConstantInput)
            {
                // add message from UiMethods?
            }
            return age;
        }
    }
}
