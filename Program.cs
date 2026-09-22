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
            
            //UiMethods.AskAboutMainCharacter(); not sure I want to call this method just yet
        }
    }
}
