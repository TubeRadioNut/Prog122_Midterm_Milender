using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_Midterm_Milender
{
    public class Product
    {
        //Fields
        string _productName;//private string field to store the product name
        decimal _price;//private decimal field to store the price of our product


        //Consstructor
        public Product(string productName, decimal price)
        {
            _productName = productName;
            _price = price;
        }

        //Properties
        public string ProductName { get => _productName; set => _productName = value; }
        public decimal Price { get => _price; set => _price = value; }

        //Methods

        public override string ToString()
        {
            return $"{_productName} - {_price:c} \n";
        }
    }//end of class
}//end of namespace
