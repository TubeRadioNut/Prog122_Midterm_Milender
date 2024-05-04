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
            //Initialize and Add 3 Predetermined Product items to each List
            _coffeeProducts = new List<Product>()
            {
                new Product("Dark Roast Coffee", 3.50m),
                new Product("Medium Roast Coffee", 3.25m),
                new Product("Light Roast Coffee", 3.00m)
            };

            _teaProducts = new List<Product>()
            {
                new Product("Black Tea", 2.75m),
                new Product("Green Tea", 2.50m),
                new Product("Chai Tea", 3.00m)
            };

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
