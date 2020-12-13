using System;

namespace Lab_3_Pizzerian.Handlers
{
    public static class UserInputHandlers
    {
        public static ConsoleKeyInfo GetUserInput()
        {
            return Console.ReadKey(true);
        }


    }
}