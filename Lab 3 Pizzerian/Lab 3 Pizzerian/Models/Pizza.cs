using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Pizzerian.Models
{
    public class Pizza
    {
        //TODO: use a factory to make pizzas, perhaps add a constructor to the pizza class, or add appropriate methods to the factory class.(better to leave the logic to the factory i.m.o)
        public string Name { get; init; }
        public int Price { get; init; }
        public IEnumerable<string> Ingredients { get; init; }
    }
}
