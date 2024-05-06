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


        //Constructor
        public Product(string productName, decimal price)
        {
            _productName = productName;
            _price = price;
        }

        //Properties
        public string ProductName { get => _productName; set => _productName = value; }
        public decimal Price { get => _price; set => _price = value; }

        //Methods
        //Create overrid ToString() method to replace default ToString() method
        public override string ToString()
        {
            //Format how Product will be displayed
            return $"{_productName} - {_price:c} \n";
        }
    }//end of class

}//end of namespace
