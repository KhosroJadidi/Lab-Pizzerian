using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Pizzerian.Data_Storage_Classes
{
    public static class ExtraIngredients
    {
        public static ExtraIngredient Ham { get; } =
            new ExtraIngredient
            {
                Name = ExtraIngredientsNames.Ham,
                Price = ExtraIngredientsPrices.Ham
            };
        public static ExtraIngredient Pineapple { get; } =
            new ExtraIngredient
            {
                Name = ExtraIngredientsNames.Pineapple,
                Price = ExtraIngredientsPrices.Pineapple
            };
        public static ExtraIngredient Mushrooms { get; } =
            new ExtraIngredient
            {
                Name = ExtraIngredientsNames.Mushrooms,
                Price = ExtraIngredientsPrices.Mushrooms
            };
        public static ExtraIngredient Onion { get; } =
            new ExtraIngredient
            {
                Name = ExtraIngredientsNames.Onion,
                Price = ExtraIngredientsPrices.Onion
            };
        public static ExtraIngredient Kebab_Sauce { get; } =
            new ExtraIngredient
            {
                Name = ExtraIngredientsNames.Kebab_Sauce,
                Price = ExtraIngredientsPrices.Kebab_Sauce
            };
        public static ExtraIngredient Shrimp { get; } =
            new ExtraIngredient
            {
                Name = ExtraIngredientsNames.Shrimp,
                Price = ExtraIngredientsPrices.Shrimp
            };
        public static ExtraIngredient Mussels { get; } =
            new ExtraIngredient
            {
                Name = ExtraIngredientsNames.Mussels,
                Price = ExtraIngredientsPrices.Mussels
            };
        public static ExtraIngredient Artichoke { get; } =
            new ExtraIngredient
            {
                Name = ExtraIngredientsNames.Artichoke,
                Price = ExtraIngredientsPrices.Artichoke
            };
        public static ExtraIngredient Kebab { get; } =
            new ExtraIngredient
            {
                Name = ExtraIngredientsNames.Kebab,
                Price = ExtraIngredientsPrices.Kebab
            };
        public static ExtraIngredient Coriander { get; } =
            new ExtraIngredient
            {
                Name = ExtraIngredientsNames.Coriander,
                Price = ExtraIngredientsPrices.Coriander
            };

    }
}
