using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Models.Products;
using Lab_3_Pizzerian.Models.StockItems;

namespace Lab_3_Pizzerian.Handlers
{
    public static class UserChoiceHandlers
    {
        internal static Pizza GetPizza(int index)
        {
            return Pizzas.AllPizzas[index];
        }

        internal static Soda GetDrink(int index)
        {
            return Sodas.AllSodas[index];
        }
    }
}