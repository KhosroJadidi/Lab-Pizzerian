using System.Collections.Generic;
using Lab_3_Pizzerian.Models.StockItems;
using Lab_3_Pizzerian.Models.Products;
using Lab_3_Pizzerian.Data_Storage_Classes;

namespace Lab_3_Pizzerian.DataStorageClasses
{
    public static class Pizzas
    {
        public static Pizza Margerita { get; } =
            new Pizza
            {
                Name = "Margerita",
                Price = 85,
                Ingredients = new List<Ingredient>()
                {
                    Ingredients.Cheese,
                    Ingredients.Tomato_Sauce
                }
            };
        public static Pizza Hawaii { get; } =
            new Pizza
            {
                Name = "Hawaii",
                Price = 95,
                Ingredients = new List<Ingredient>()
                {
                    Ingredients.Cheese,
                    Ingredients.Tomato_Sauce,
                    Ingredients.Ham,
                    Ingredients.Pineapple
                }
            };
        public static Pizza Kebab_Pizza { get; } =
            new Pizza
            {
                Name = "Kebab pizza",
                Price = 105,
                Ingredients = new List<Ingredient>()
                {
                    Ingredients.Cheese,
                    Ingredients.Tomato_Sauce,
                    Ingredients.Kebab,
                    Ingredients.Mushrooms,
                    Ingredients.Onion,
                    Ingredients.Feferoni,
                    Ingredients.Iceberg_lettuce,
                    Ingredients.Tomato,
                    Ingredients.Kebab_Sauce
                }
            };
        public static Pizza Quattro_Stadioni { get; } =
            new Pizza
            {
                Name = "Quattro stadioni",
                Price = 115,
                Ingredients = new List<Ingredient>()
                {
                    Ingredients.Cheese,
                    Ingredients.Tomato_Sauce,
                    Ingredients.Ham,
                    Ingredients.Shrimp,
                    Ingredients.Mussels,
                    Ingredients.Mushrooms,
                    Ingredients.Artichoke
                }
            };
    }
}
