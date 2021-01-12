using Lab_3_Pizzerian.Data_Storage_Classes;
using Lab_3_Pizzerian.Models.Products;
using Lab_3_Pizzerian.Models.StockItems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_3_Pizzerian.Controller.Decorators
{
    public sealed class PizzaDecorator
    {
        private PizzaDecorator()
        {
        }

        public static PizzaDecorator Decorator { get; set; } =
            new PizzaDecorator();

        public Pizza AddExtras(Pizza pizza, int index)
        {
            Pizza clone = ClonePizza(pizza);
            var chosenExtraName = Ingredients.GetExtra()[index];
            var extra = Ingredients.Extras
                .Single(ex => ex.Name == chosenExtraName);
            if (clone.ExtraIngredients is null)
            {
                clone.ExtraIngredients = new List<Ingredient> { extra };
            }
            else if (!clone.ExtraIngredients.Contains(extra))
            {
                clone.ExtraIngredients.Append(extra);
            }
            return clone;
        }

        private static Pizza ClonePizza(Pizza pizza)
        {
            return new Pizza
            {
                Name = pizza.Name,
                Price = pizza.Price,
                Ingredients = pizza.Ingredients,
                ExtraIngredients = pizza.ExtraIngredients
            };
        }
    }
}