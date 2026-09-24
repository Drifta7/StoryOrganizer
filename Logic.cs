using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryOrganizer
{
    internal class Logic
    {
        public static char ValidateUserYesNo()
        {
            char yesOrNoAnswer = Console.ReadKey().KeyChar;
            char.ToUpper(yesOrNoAnswer);
            return yesOrNoAnswer;
        }
       
        public static int AgeLogicCalculator(int input , int ConstantInput) // age less or equal to OR greater than
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
