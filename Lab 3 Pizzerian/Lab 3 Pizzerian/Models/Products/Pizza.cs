using Lab_3_Pizzerian.Models.StockItems;
using System.Collections.Generic;

namespace Lab_3_Pizzerian.Models.Products
{
    public class Pizza
    {
        //TODO: use a factory to make pizzas, perhaps add a constructor to the pizza class, or add appropriate methods to the factory class.(better to leave the logic to the factory i.m.o)
        public string Name { get; init; }
        public int Price { get; init; }
        public IEnumerable<Ingredient> Ingredients { get; init; }
    }
}
