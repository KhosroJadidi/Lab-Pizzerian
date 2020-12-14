using Lab_3_Pizzerian.Controller.Decorators;
using Lab_3_Pizzerian.Models.Products;
using Lab_3_Pizzerian.Viewer;
using System;

namespace Lab_3_Pizzerian.Handlers
{
    internal class OrderRowHandlers
    {
        internal static Pizza HandlePizzaChoice()
        {
            while (true)
            {
                MessageHandlers.AskForPizza();
                var pizzaChoice = UserInputHandlers.GetUserInput();
                var validatedChoice = UserInputHandlers.ValidatePizzaChoice(pizzaChoice);
                if (!validatedChoice.Item1)
                {
                    MessageHandlers.PrintWrongChoice();
                }
                else
                {
                    return UserChoiceHandlers.GetPizza(validatedChoice.Item2);
                }
            }
        }

        internal static Pizza HandleExtrasChoice(Pizza pizza)
        {
            while (true) 
            {                        
                MessageHandlers.AskForExtras();
                var extraChoice = UserInputHandlers.GetUserInput();
                var validatedChoice = 
                    UserInputHandlers.ValidateExtrasChoice(extraChoice);
                if (!validatedChoice.Item1)
                {
                    MessageHandlers.PrintWrongChoice();
                }
                else
                {
                    var decorator = PizzaDecorator.Decorator;
                    pizza=decorator.AddExtras(pizza,validatedChoice.Item2);
                    MessageHandlers.AskForMore();
                    var answer = UserInputHandlers.GetUserInput();
                    var validatedAnswer =
                        UserInputHandlers.ValidateMoreAnswer(answer);
                    if (!validatedAnswer)
                        break;
                }
            }
            return pizza;
        }
    }
}