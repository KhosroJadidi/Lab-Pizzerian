using Lab_3_Pizzerian.Data_Storage_Classes;
using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Models.Orders;
using System;

namespace Lab_3_Pizzerian.Viewer
{
    public class MessageHandlers
    {
        public static void PrintWelcome()
        {
            var message = "Hello!" +
                "\nWelcome to our pizzeria!";
            Console.Write(message);
        }

        public static void ShowAvailableOptions()
        {
            var options = "\n\nPlease enter the corresponding number." +
                "\n\nPizza(0)" +
                "\nDrink(1)" +
                "\n\nFinalize all orders(Y)" +
                "\nCancel all orders(N)";
            Console.Write(options);
        }

        public static void AskForPizza()
        {
            var message = "\n\nWhich pizza would u like to order?";
            foreach (var pizza in Pizzas.PizzaNames)
            {
                message += $"\n{pizza}";
            }
            message += "\n";
            Console.Write(message);
        }

        public static void AskForExtras()
        {
            var message = "\n\nWould you like to add extra ingredients to your pizza?";
            var extras = Ingredients.GetExtra();
            foreach (var extra in extras)
            {
                message += $"\n{extra}";
            }
            message += "\n";
            Console.Write(message);
        }

        public static void AskForDrinks()
        {
            var message = "\n\nWould you like to add a drink to your order?";
            var sodas = Sodas.SodaNames;
            foreach (var soda in sodas)
            {
                message += $"\n{soda}";
            }
            message += "\n";
            Console.Write(message);
        }

        public static void AskForNextStep()
        {
            var message = "\n\nWhat would you like to do next?";
            Console.Write(message);
        }
    }
}