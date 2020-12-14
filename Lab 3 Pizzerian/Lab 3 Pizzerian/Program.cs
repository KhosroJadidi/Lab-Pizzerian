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
            OrderHandlers.HandleOrder();            
        }
    }
}