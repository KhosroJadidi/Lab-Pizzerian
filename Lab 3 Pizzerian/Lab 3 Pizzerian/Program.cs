using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Handlers;
using Lab_3_Pizzerian.Viewer;

namespace Lab_3_Pizzerian
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            MessageHandlers.PrintWelcome();
            var pizza=OrderRowHandlers.HandlePizzaChoice();
            if(pizza.Name!=Pizzas.None.Name)
                pizza = OrderRowHandlers.HandleExtrasChoice(pizza);
            
            
            MessageHandlers.AskForDrinks();
            var drinksInput = UserInputHandlers.GetUserInput();
        }
    }
}