using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Models.Orders;
using Lab_3_Pizzerian.Models.Products;
using Lab_3_Pizzerian.Models.StockItems;

namespace Lab_3_Pizzerian.Controller.Factories
{
    public sealed class OrderRowFactory
    {
        private int rowId = 1;

        private OrderRowFactory()
        {
        }

        public static OrderRowFactory RowFactory { get; set; } =
                new OrderRowFactory();

        public OrderRow CreateOrderRow(Pizza pizza, Soda soda)
        {
            var pizzaPrice = pizza.Price;
            var extraPrice = 0;
            if (pizza.ExtraIngredients != null)
            {
                foreach (var ing in pizza.ExtraIngredients)
                {
                    extraPrice += ing.PriceAsExtra;
                }
            }

            var sodaPrice = soda.Price;
            var totalPrice = pizzaPrice + extraPrice + sodaPrice;

            var orderRow = new OrderRow
            {
                RowId = rowId,
                Pizza = pizza,
                Soda = soda,
                TotalPrice = totalPrice
            };
            OrderRows.Rows.Add(orderRow);
            rowId++;
            return orderRow;
        }
    }
}