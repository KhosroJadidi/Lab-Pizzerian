using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Pizzerian.Controller.Decorators
{
    public sealed class PizzaDecorator
    {
        private PizzaDecorator()
        {
        }
        public static PizzaDecorator Decorator { get; set; } =
            new PizzaDecorator();

        //TODO:implement methods for adding and removing extra ingredients to the pizza.
    }
}
