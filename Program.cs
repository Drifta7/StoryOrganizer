namespace StoryOrganizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isUserDoneBrainStorming = false;

            UiMethods.UserGreeting();
            UiMethods.DisplayCategories();

            char AnswerForCharacterSelection = UiMethods.ValidateUserSelection(UiMethods.UserSelection());

            UiMethods.PrintWhatTheUserSelected(AnswerForCharacterSelection);

            BrainStormDump idea = new BrainStormDump();

            // idea.Content = " the motorcycle has been stolen, and it was her fathers ride";

            // Console.WriteLine(idea.Content);
            char userYesOrNoAns = Logic.ValidateUserYesNo();

            string userAnswer = UiMethods.AskUserQuestion();
            idea.Content = userAnswer;
            UiMethods.DisplayUserAnswer(idea.Content);

            while (!isUserDoneBrainStorming)
            {
                UiMethods.AskIfUserIsDoneQuestion();

                if (userYesOrNoAns == Constants._YES)
                {
                    for ( int i = 0; i < Constants.TIMES_USER_HAS_CREATED_IDEAS; i++)
                    {
                        
                    }

                    // deciding if there should be a for loop for the amount of ideas that the user wants to put in
                    // the user should dump a X number of ideas then the app ask are you finished ot not then asked  
                    // the question whether they are or not

                    isUserDoneBrainStorming = true;
                }
                else if (userYesOrNoAns == Constants._NO)
                {
                    continue;
                }

            }

            //UiMethods.AskAboutMainCharacter(); not sure I want to call this method just yet
        }
    }
}
