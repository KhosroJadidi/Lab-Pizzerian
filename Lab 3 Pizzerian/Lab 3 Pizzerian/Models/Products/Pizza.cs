using Lab_3_Pizzerian.Models.StockItems;
using System.Collections.Generic;

namespace Lab_3_Pizzerian.Models.Products
{
    public class Pizza
    {
        public string Name { get; init; }

        public int Price { get; init; }
        public IEnumerable<Ingredient> Ingredients { get; init; }
#nullable enable
        public IEnumerable<Ingredient>? ExtraIngredients { get; set; }
#nullable disable
    }
}