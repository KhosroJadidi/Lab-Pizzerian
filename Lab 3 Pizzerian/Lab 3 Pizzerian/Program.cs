using Lab_3_Pizzerian.Controller.Factories;
using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Handlers;
using Lab_3_Pizzerian.Models.StockItems;
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
            var orderRows=OrderRowHandlers.CreateOrderList();
            MessageHandlers.DisplayOrderList(orderRows);

        }
    }
}