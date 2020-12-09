using Lab_3_Pizzerian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Pizzerian.DataStorageClasses
{
    public static class Sodas
    {
        public static Soda Coca_Cola { get; } =
            new Soda
            {
                Name = SodasNames.Coca_Cola,
                Price = SodasPrices.Coca_Cola
            };

        public static Soda Fanta { get; } =
            new Soda
            {
                Name = SodasNames.Fanta,
                Price = SodasPrices.Fanta
            };

        public static Soda Sprite { get; } =
            new Soda
            {
                Name = SodasNames.Sprite,
                Price = SodasPrices.Sprite
            };
    }
}
