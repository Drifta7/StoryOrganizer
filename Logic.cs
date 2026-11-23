namespace StoryOrganizer
{
    public static class Logic
    {
       
        // this allows the User to create as many ideas they want
        public static void UserDrivenInputToClass(IdeaCanvasDump dump) // <-------this method work great which will stay.
        {
            for (int i = 0; i < Constants.IDEA_COUNTER; i++)
            {
                dump.DumpArea.Add(UiMethods.AskUserAboutIdea()); // this places the Ideas into DumpArea
            }
        }

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
