using Lab_3_Pizzerian.Models.StockItems;

namespace Lab_3_Pizzerian.Data_Storage_Classes
{
    internal static class Ingredients
    {
        public static Ingredient Cheese { get; } =
            new Ingredient
            {
                Name = "Cheese"
            };

        public static Ingredient TomatoSauce { get; } =
            new Ingredient
            {
                Name = "Tomato Sauce"
            };

        public static Ingredient Feferoni { get; } =
            new Ingredient
            {
                Name = "Feferoni",
            };

        public static Ingredient Iceberglettuce { get; } =
            new Ingredient
            {
                Name = "Iceberg lettuce",
            };

        public static Ingredient Tomato { get; } =
            new Ingredient
            {
                Name = "Tomato",
            };

        public static Ingredient Ham { get; } =
            new Ingredient
            {
                Name = "Ham",
                PriceAsExtra = IngredientPriceClass.A
            };

        public static Ingredient Pineapple { get; } =
            new Ingredient
            {
                Name = "Pineapple",
                PriceAsExtra = IngredientPriceClass.A
            };

        public static Ingredient Mushrooms { get; } =
            new Ingredient
            {
                Name = "Mushrooms",
                PriceAsExtra = IngredientPriceClass.A
            };

        public static Ingredient Onion { get; } =
            new Ingredient
            {
                Name = "Onion",
                PriceAsExtra = IngredientPriceClass.A
            };

        public static Ingredient KebabSauce { get; } =
            new Ingredient
            {
                Name = "Kebab Sauce",
                PriceAsExtra = IngredientPriceClass.A
            };

        public static Ingredient Shrimp { get; } =
            new Ingredient
            {
                Name = "Shrimp",
                PriceAsExtra = IngredientPriceClass.B
            };

        public static Ingredient Mussels { get; } =
            new Ingredient
            {
                Name = "Mussels",
                PriceAsExtra = IngredientPriceClass.B
            };

        public static Ingredient Artichoke { get; } =
            new Ingredient
            {
                Name = "Artichoke",
                PriceAsExtra = IngredientPriceClass.B
            };

        public static Ingredient Kebab { get; } =
            new Ingredient
            {
                Name = "Kebab",
                PriceAsExtra = IngredientPriceClass.C
            };

        public static Ingredient Coriander { get; } =
            new Ingredient
            {
                Name = "Coriander",
                PriceAsExtra = IngredientPriceClass.C
            };

        //TODO: Add a visitor pattern to select out the ingredients that have a price higher than 0.
        public static Ingredient[] Extras => new[]
        {
            Ham,
            Pineapple,
            Mushrooms,
            Onion,
            KebabSauce,
            Shrimp,
            Mussels,
            Artichoke,
            Kebab,
            Coriander
        };

        public static Ingredient GetExtra(int index)
        {
            return Extras[index];
        }
    }
}