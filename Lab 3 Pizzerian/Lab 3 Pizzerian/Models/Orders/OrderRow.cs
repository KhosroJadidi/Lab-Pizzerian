using System.Collections.Generic;
using Lab_3_Pizzerian.Models.Products;
using Lab_3_Pizzerian.Models.StockItems;

namespace Lab_3_Pizzerian.Models.Orders
{
    internal class OrderRow
    {
        //! Row id should start from 1.
        public int rowId { get; set; }
        public Pizza Pizza { get; set; }
        public Soda Soda { get; set; }
        public IEnumerable<Ingredient> ExtraIngredients { get; set; }
    }
}