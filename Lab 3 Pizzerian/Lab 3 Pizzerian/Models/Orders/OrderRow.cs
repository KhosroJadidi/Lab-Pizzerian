using Lab_3_Pizzerian.Models.Products;
using Lab_3_Pizzerian.Models.StockItems;

namespace Lab_3_Pizzerian.Models.Orders
{
    public class OrderRow
    {
        public int RowId { get; set; }
        public Pizza Pizza { get; set; }
        public Soda Soda { get; set; }
        public int TotalPrice { get; set; }
    }
}