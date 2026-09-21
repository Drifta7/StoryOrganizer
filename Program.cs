namespace StoryOrganizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UiMethods.UserGreeting();
            UiMethods.DisplayCategories();  
            
            //UiMethods.AskAboutMainCharacter(); not sure I want to call this method just yet
        }
    }
}
