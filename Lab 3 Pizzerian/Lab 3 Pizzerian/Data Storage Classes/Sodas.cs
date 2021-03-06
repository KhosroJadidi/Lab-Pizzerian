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

        public static Soda None { get; } =
            new Soda
            {
                Name = "None",
                Price = 0
            };

        public static Soda[] AllSodas =>
            new[]
            {
                CocaCola,
                Fanta,
                Sprite,
                None
            };

        public static string[] SodaNames =>
            new[]
            {
                CocaCola.Name,
                Fanta.Name,
                Sprite.Name,
                None.Name
            };
    }
}