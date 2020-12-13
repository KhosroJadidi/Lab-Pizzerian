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
                    Ingredients.TomatoSauce
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
                    Ingredients.TomatoSauce,
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
                    Ingredients.TomatoSauce,
                    Ingredients.Kebab,
                    Ingredients.Mushrooms,
                    Ingredients.Onion,
                    Ingredients.Feferoni,
                    Ingredients.Iceberglettuce,
                    Ingredients.Tomato,
                    Ingredients.KebabSauce
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
                    Ingredients.TomatoSauce,
                    Ingredients.Ham,
                    Ingredients.Shrimp,
                    Ingredients.Mussels,
                    Ingredients.Mushrooms,
                    Ingredients.Artichoke
                }
            };
        public static Pizza None { get; } =
            new Pizza
            {
                Name = "None",
                Price = 0,
                Ingredients = new List<Ingredient>()
                {}                                    
            };
        public static string[] PizzaNames =>
            new [] 
            {
                Margerita.Name,
                Hawaii.Name,
                Kebab_Pizza.Name,
                Quattro_Stadioni.Name,
                None.Name
            };
    }
}
