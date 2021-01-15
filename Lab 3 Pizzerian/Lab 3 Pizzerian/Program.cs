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
            OrderHandlers.HandleOrder();
        }
    }
}