using Lab_3_Pizzerian.Controller;
using Lab_3_Pizzerian.Controller.Decorators;
using Lab_3_Pizzerian.Controller.Factories;
using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Viewer;
using System.Linq;

namespace Lab_3_Pizzerian.Handlers
{
    public class OrderHandlers
    {
        internal static void HandleOrder()
        {
            var orderRows = OrderRowHandlers.CreateOrderList();
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
                var updatedOrder = OrderRowDecorator.RowDecorator
                    .ReplaceOrderRow(confirmation.Item2, orderRow);
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