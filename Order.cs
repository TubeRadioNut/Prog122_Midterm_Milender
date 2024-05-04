using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Media3D;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace Prog122_Midterm_Milender
{
    public class Order
    {
        //- Define a customers order.Will hold the customer name, the list of products they are buying, and calculations
        //Fields
        string _orderNumber;
        string _customerName;
        decimal _tax;
        List<Product> _productInOrder;

        //  _orderNumber : string
        //  _productsInOrder : List<Product>
        //_customerName : string
        //_tax = decimal(you can set this to .1m to make it 10 percent


        //Constructor
        //  public Order()
        //Inside of the constructor set the _orderNumber to a random number between 10,000,000 and 100,000,000
        //Inside of the constructor, initialize the _productsInOrder with a new List<Product>()
        public Order()
        {
            //Generate a random order number between 10,000,000 and 100,000,000
            Random rand = new Random();
            _orderNumber = rand.Next(10000000, 100000000).ToString();
            //assign _tax .1
            _tax = .1m;
            //Initialize our Product List
            _productInOrder = new List<Product>();
        }

        //Properties
        //Create a get for OrderNumber, ProductsInOrder, and CustomerName
        //OrderNumber and ProductsInOrder should NOT have a set
        public string OrderNumber { get { return _orderNumber; } }
        public string CustomerName { get { return _customerName; } set { _customerName = value; } }
        public List<Product> PorductInOrder { get { return _productInOrder; } }

        //Method
        //public void AddProduct(Product) : Create a method that takes a product and adds it to the instance ProductsInOrder.
        public void AddProduct (Product product)
        {
            _productInOrder.Add(product);
        }

        //public string FormattedOrder() : Create a method that will create a string that has the user number, name, all the products
        //they have ordered, and the product total summary.Example below.
        public string FormattedOrder()
        {
            decimal subtotal = Subtotal();
            decimal tax = _tax * 100;
            decimal totalTax = TotalTax(subtotal);
            decimal total = Total(subtotal);

            string formatString = "";
            formatString += $"Order Number: {_orderNumber}\n";
            formatString += $"Customer Name: {_customerName}\n";
            formatString += $"\n";
            formatString += $"--Products--\n";

            for (int i=0; i < _productInOrder.Count; i++)
            {
                formatString += _productInOrder[i].ToString() ;
            }
            formatString += $"Subtotal: {subtotal:c}\n";
            formatString += $"Tax: {tax}% \n";
            formatString += $"Total Tax: {totalTax:c} \n";
            formatString += $"Total: {total:c} \n";
            
            return formatString;
        }
        
        //Creates the Subtotal() method that adds all the prices of the order and returns that total, this is
        //the subtotal of the order
        public decimal Subtotal()
        {
            //Loop through _productInOrder List adding Prodcut Prices
            decimal subtotal = 0;
            for(int i = 0; i < _productInOrder.Count; i++)
            {
                subtotal += _productInOrder[i].Price;
            }

            return subtotal;
        }

        //Creates the Subtax() method that take a decimal in its parameters and returns the product of subtotal * _tax, this the
        //total dollar amount of tax of the order
        public decimal TotalTax(decimal subtotal)
        {
            return subtotal * _tax;
        }
        //Creates Total() method that takes a decimal in its parameters and returns the product of subtotal * (_tax + 1) this is
        //total dollar amount of the order
        public decimal Total(decimal subtotal)
        {
            decimal total = subtotal * (_tax + 1);
            return total;
        }

        //Creates override ToString() method that replaces default ToString() method
        public override string ToString()
        {
            return $"{_customerName} - {_orderNumber}";
        }

    }//end of class

}//end of namespace
