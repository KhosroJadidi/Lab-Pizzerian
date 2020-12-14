using Lab_3_Pizzerian.Data_Storage_Classes;
using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Handlers;
using Lab_3_Pizzerian.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_3_Pizzerian.Viewer
{
    public class MessageHandlers
    {
        public static void PrintWelcome()
        {
            var message = "Hello!" +
                "\nWelcome to our pizzeria!" +
                "\nPlease enter the corresponding number and press ENTER.";
            Console.Write(message);
        }

        public static void AskForPizza()
        {
            var message = "\n\nWhich pizza would u like to order?";
            var pizzas = Pizzas.PizzaNames;
            for (int i = 0; i < pizzas.Length; i++)
            {
                message += $"\n{pizzas[i]} ({i})";
            }
            message += "\n";
            Console.Write(message);
        }

        public static void AskForConfirmation()
        {
            Console.WriteLine("Are you happy with your order?");
            Console.WriteLine("Yes(0)");
            Console.WriteLine("No, I want to re-order the following ID:");
        }

        public static void DisplayOrderList(List<OrderRow> orderRows)
        {
            Console.WriteLine("\n\nYou have the following order rows:");
            for (int i = 0; i < orderRows.Count; i++)
            {
                Console.WriteLine($"Row ID:{orderRows[i].RowId}");
                Console.WriteLine($"Pizza:{orderRows[i].Pizza.Name}");
                Console.WriteLine("Ingredients:");
                var ingredients=orderRows[i].Pizza.Ingredients;
                foreach (var ing in ingredients)
                {
                    Console.WriteLine(ing.Name);
                }
                Console.WriteLine("Extra ingredients:");
                var extraIngredients = orderRows[i].Pizza.ExtraIngredients;
                if(extraIngredients!=null)
                {
                    foreach (var ing in extraIngredients)
                    {
                        Console.WriteLine(ing.Name);
                    }
                }
                
                Console.WriteLine($"Soda: {orderRows[i].Soda.Name}");
                Console.WriteLine($"Total Price: {orderRows[i].TotalPrice}");
            }
            var totalPrice = OrderRowHandlers.GetTotalPriceForOrderRow();
            Console.WriteLine($"\n\nTotal price for the order row: {totalPrice}");
        }

        public static void PrintSubmitted()
        {
            Console.WriteLine("You Order Has Been Submitted.");
        }

        public static void PrintWrongChoice()
        {
            var message = "Wrong input! Please try again.";
            Console.WriteLine(message);
        }

        public static void AskForExtras()
        {
            var message = "\n\nWould you like to add extra ingredients to your pizza?";
            var extras = Ingredients.GetExtra();
            for (int i = 0; i < extras.Length; i++)
            {
                message += $"\n{extras[i]} ({i})";
            }
            message += "\n";
            Console.Write(message);
        }

        public static void AskForDrinks()
        {
            var message = "\n\nWould you like to add a drink to your order?";
            var sodas = Sodas.SodaNames;
            for (int i = 0; i < sodas.Length; i++)
            {
                message += $"\n{sodas[i]} ({i})";
            }
            message += "\n";
            Console.Write(message);
        }

        public static void AskForMoreIngredients()
        {
            var message = "Would you like to add more?" +
                "\nYes(0)" +
                "\nNo(1)";
            Console.WriteLine(message);
        }

        public static void AskForNextStep()
        {
            var message = "\n\nWhat would you like to do next?";
            Console.Write(message);
        }

        public static void AskForMoreOrderRows()
        {
            var message = "Would you like to add more order rows?" +
                "\nYes(0)" +
                "\nNo(1)";
            Console.Write(message);
        }
    }
}