﻿using Lab_3_Pizzerian.Data_Storage_Classes;
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