using Lab_3_Pizzerian.Data_Storage_Classes;
using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Pizzerian.Handlers
{
    public static class UserChoiceHandlers
    {
        internal static Pizza GetPizza(int index)
        {
            return Pizzas.AllPizzas[index];
        }        
    }
}
