﻿using Lab_3_Pizzerian.Controller.Decorators;
using Lab_3_Pizzerian.Controller.Factories;
using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Models.Orders;
using Lab_3_Pizzerian.Models.Products;
using Lab_3_Pizzerian.Models.StockItems;
using Lab_3_Pizzerian.Viewer;
using System.Collections.Generic;

namespace Lab_3_Pizzerian.Handlers
{
    public class OrderRowHandlers
    {
        public static Pizza HandlePizzaChoice()
        {
            while (true)
            {
                MessageHandlers.AskForPizza();
                var pizzaChoice = UserInputHandlers.GetUserInput();
                var validatedChoice = UserInputHandlers
                    .ValidatePizzaChoice(pizzaChoice);
                if (!validatedChoice.Item1)
                {
                    MessageHandlers.PrintWrongChoice();
                }
                else
                {
                    return UserChoiceHandlers
                        .GetPizza(validatedChoice.Item2);
                }
            }
        }

        public static Pizza HandleExtrasChoice(Pizza pizza)
        {
            while (true)
            {
                MessageHandlers.AskForExtras();
                var extraChoice = UserInputHandlers.GetUserInput();
                var validatedChoice = UserInputHandlers
                    .ValidateExtrasChoice(extraChoice);
                if (!validatedChoice.Item1)
                {
                    MessageHandlers.PrintWrongChoice();
                }
                else
                {
                    var decorator = PizzaDecorator.Decorator;
                    pizza = decorator
                        .AddExtras(pizza, validatedChoice.Item2);
                    MessageHandlers.AskForMoreIngredients();
                    var answer = UserInputHandlers.GetUserInput();
                    var validatedAnswer = UserInputHandlers
                        .ValidateMoreAnswer(answer);
                    if (!validatedAnswer)
                        break;
                }
            }
            return pizza;
        }

        public static Soda HandleDrinkChoice()
        {
            while (true)
            {
                MessageHandlers.AskForDrinks();
                var drinkChoice = UserInputHandlers.GetUserInput();
                var validatedChoice = UserInputHandlers
                    .ValidateDrinkChoice(drinkChoice);
                if (!validatedChoice.Item1)
                {
                    MessageHandlers.PrintWrongChoice();
                }
                else
                {
                    return UserChoiceHandlers
                        .GetDrink(validatedChoice.Item2);
                }
            }
        }

        public static List<OrderRow> CreateOrderList()
        {
            var orderRowList = new List<OrderRow>();
            while (true)
            {
                var pizza = HandlePizzaChoice();
                if (pizza.Name != Pizzas.None.Name)
                    pizza = HandleExtrasChoice(pizza);
                var drink = HandleDrinkChoice();
                var orderRow = OrderRowFactory.RowFactory
                    .CreateOrderRow(pizza, drink);
                orderRowList.Add(orderRow);
                var userWantsMoreOrderRoews = HandleMoreOrderRowsChoice();
                if (!userWantsMoreOrderRoews)
                    break;
            }
            return orderRowList;
        }

        public static int GetTotalPriceForOrderRow()
        {
            var total = 0;
            foreach (var order in OrderRows.Rows)
            {
                total += order.TotalPrice;
            }
            return total;
        }

        private static bool HandleMoreOrderRowsChoice()
        {
            MessageHandlers.AskForMoreOrderRows();
            var answer = UserInputHandlers.GetUserInput();
            return UserInputHandlers.ValidateMoreAnswer(answer);
        }
    }
}