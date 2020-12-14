using Lab_3_Pizzerian.Controller;
using Lab_3_Pizzerian.Controller.Decorators;
using Lab_3_Pizzerian.Controller.Factories;
using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Handlers;
using Lab_3_Pizzerian.Models.StockItems;
using Lab_3_Pizzerian.Viewer;
using System.Linq;

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
            var orderRows=OrderRowHandlers.CreateOrderList();
            while (true)
            {
                MessageHandlers.DisplayOrderList(orderRows);
                MessageHandlers.AskForConfirmation();
                var answer = UserInputHandlers.GetUserInput();
                var confirmation = UserInputHandlers
                    .ValidateConfirmationAnswer(answer);
                if (confirmation.Item1) break;
                var pizza = OrderRowHandlers.HandlePizzaChoice();
                if (pizza.Name != Pizzas.None.Name)
                    pizza = OrderRowHandlers.HandleExtrasChoice(pizza);
                var drink = OrderRowHandlers.HandleDrinkChoice();
                var orderRow = OrderRowFactory.RowFactory
                    .CreateOrderRow(pizza, drink);
                var updatedOrder=OrderRowDecorator.RowDecorator
                    .UpdateOrderRow(confirmation.Item2, orderRow);
                var orderToRemove = OrderRows.Rows
                    .Single(row => row.RowId == confirmation.Item2);
                OrderRows.Rows.Remove(orderToRemove);
                OrderRows.Rows.OrderBy(row => row.RowId);
            }
            var rows = OrderRows.Rows.ToList();
            var order = OrderFactory.Factory
                .CreateOrder(rows);
            Orders.OrdersList.Add(order);
            MessageHandlers.PrintSubmitted();
        }
    }
}