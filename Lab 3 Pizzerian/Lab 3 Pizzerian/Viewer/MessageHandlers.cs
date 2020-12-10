using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Pizzerian.Viewer
{
    public class MessageHandlers
    {
        public static void PrintWelcome()
        {
            var welcomeMessage = "Hello!" +
                "\nWhat would you like to order?";
            Console.Write(welcomeMessage);
        }
        public static void AskForPizza()
        {
            var welcomeMessage = "Which pizza would u like to order?";
            Console.Write(welcomeMessage);
        }

        public static void AskForExtras()
        {
            var welcomeMessage = "Would you like to add extra ingredients to your pizza?";
            Console.Write(welcomeMessage);
        }

        public static void AskForDrinks()
        {
            var welcomeMessage = "Would you like to add a drink to your order?";
            Console.Write(welcomeMessage);
        }

        public static void AskForNextStep()
        {
            var welcomeMessage = "What would you like to do next?";
            Console.Write(welcomeMessage);
        }
    }
}
