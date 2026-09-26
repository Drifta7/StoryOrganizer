namespace StoryOrganizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isUserDoneBrainStorming = false;

            UiMethods.UserGreeting();
            UiMethods.DisplayCategories();

            char AnswerForCharacterSelection = Logic.ValidateUserSelectionInMenu(UiMethods.UserSelection());

            Console.Clear();

            UiMethods.PrintWhatTheUserSelected(AnswerForCharacterSelection);

            BrainStormDump idea = new BrainStormDump();

            // idea.Content = " the motorcycle has been stolen, and it was her fathers ride"; // example

            // Console.WriteLine(idea.Content);



            // this is where the user puts in their ideas that is save to a variable.


            BrainStormDump UserIdeas = new BrainStormDump(); // for ideas



            UserIdeas.UserContent.Add(""); // where the user manually puts in ideas
            // how do you create a dyanamic list where the user adds as much ideas as they want?

            UiMethods.DisplayUserAnswer(idea.Content);

            while (!isUserDoneBrainStorming)
            {
                UiMethods.AskIfUserIsDoneQuestion(); // this is just a display question

                char userYesOrNoAns = Logic.ValidateUserYesNo(); // where the User anwsers the question with Y or N 

                if (userYesOrNoAns == Constants._NO)
                {
                    string userAnswer = UiMethods.AskUserAboutIdea(); // this is where the user types up the potential idea dump, 
                    idea.Content = userAnswer;

                    //for ( int i = 0; i < Constants.TIMES_USER_HAS_CREATED_IDEAS; i++)
                    //{
                    //    // the decision works will implement this later afterwards 
                    //}

                    // deciding if there should be a for loop for the amount of ideas that the user wants to put in
                    // the user should dump a X number of ideas then the app ask are you finished ot not then asked  
                    // the question whether they are or not
                    //continue;

                }
                else if (userYesOrNoAns == Constants._YES)
                {
                    isUserDoneBrainStorming = true;
                }

            }

            //UiMethods.AskAboutMainCharacter(); not sure I want to call this method just yet
        }
    }
}
