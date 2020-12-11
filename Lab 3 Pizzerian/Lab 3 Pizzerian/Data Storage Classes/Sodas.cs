﻿using Lab_3_Pizzerian.Models.StockItems;

namespace Lab_3_Pizzerian.DataStorageClasses
{
    public static class Sodas
    {
        public static Soda CocaCola { get; } =
            new Soda
            {
                Name = "Coca Cola",
                Price = 20
            };

        public static Soda Fanta { get; } =
            new Soda
            {
                Name = "Fanta",
                Price = 20
            };

        public static Soda Sprite { get; } =
            new Soda
            {
                Name = "Sprite",
                Price = 25
            };
    }
}