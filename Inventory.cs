using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_Midterm_Milender
{
    internal class Inventory
    {
        //Fields
        List<Product> _coffeeProducts;//Declaring a list of product for our coffee products
        List<Product> _teaProducts;//Declareing a list of product for our tea products
        List<Product> _breakfastProducts;//Declaring a list of product for our breakfast products

        //Constructor
        public Inventory()
        {
            //Initialize and Add 9 Predetermined Product items to coffee products and tea products
            _coffeeProducts = new List<Product>()
            {
                new Product("Dark Roast Coffee: Small", 3.50m),
                new Product("Dark Roast Coffee: Medium", 3.85m),
                new Product("Dark Roast Coffee: Large", 4.20m),
                new Product("Medium Roast Coffee: Small", 3.25m),
                new Product("Medium Roast Coffee: Medium", 3.75m),
                new Product("Medium Roast Coffee: Large", 3.90m),
                new Product("Light Roast Coffee: Small", 3.00m),
                new Product("Light Roast Coffee: Medium", 3.30m),
                new Product("Light Roast Coffee: large", 3.60m)
            };

            _teaProducts = new List<Product>()
            {
                new Product("Black Tea: Small", 2.75m),
                new Product("Black Tea: Medium", 3.03m),
                new Product("Black Tea: Large", 3.30m),
                new Product("Green Tea: Samll", 2.50m),
                new Product("Green Tea: Medium", 2.75m),
                new Product("Green Tea: Large", 3.00m),
                new Product("Chai Tea: Small", 3.00m),
                new Product("Chai Tea: Medium", 3.30m),
                new Product("Chai Tea: Large", 3.60m)
            };
            //Initialize and Add 3 predetermined Product items
            _breakfastProducts = new List<Product>()
            {
                new Product("Sandwich", 4.99m),
                new Product("Pastry", 2.99m),
                new Product("Fruit", 3.75m)
            };
        }

        //Properties
        public List<Product> CoffeeProducts { get => _coffeeProducts; }
        public List<Product> TeaProducts { get => _teaProducts; }
        public List<Product> BreakfastProducts { get => _breakfastProducts; }
    }//end of class
}//end of namespace
