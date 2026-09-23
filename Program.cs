namespace StoryOrganizer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UiMethods.UserGreeting();
            UiMethods.DisplayCategories();

            char AnswerForCharacterSelection = UiMethods.ValidateUserSelection(UiMethods.UserSelection());

            UiMethods.PrintWhatTheUserSelected(AnswerForCharacterSelection);

            BrainStormDump idea = new BrainStormDump();

           // idea.Content = " the motorcycle has been stolen, and it was her fathers ride";

           // Console.WriteLine(idea.Content);

            string userAnswer = UiMethods.AskUserQuestion();
            idea.Content = userAnswer;
            UiMethods.DisplayUserAnswer(idea.Content);

            //UiMethods.AskAboutMainCharacter(); not sure I want to call this method just yet
        }
    }
}
