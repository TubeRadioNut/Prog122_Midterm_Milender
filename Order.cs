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
        //Fields
        string _orderNumber;//Private field string to store oreder number 
        string _customerName;//Private field string to store customer name
        decimal _tax;//Private decimal to store tax rate
        List<Product> _productInOrder;//Private List of product to store product in

        
        //Constructor
        //  public Order()
        
        public Order()
        {
            //Generate a random order number between 10,000,000 and 100,000,000
            Random rand = new Random();
            _orderNumber = rand.Next(10000000, 100000000).ToString();
            //assign _tax .1
            _tax = .1m;
            //Initialize Product List
            _productInOrder = new List<Product>();
        }

        //Properties
        public string OrderNumber { get { return _orderNumber; } }
        public string CustomerName { get { return _customerName; } set { _customerName = value; } }
        public List<Product> ProductInOrder { get { return _productInOrder; } }

        //Method
        //Create AddProduct() method for easier adding of product to List of product
        public void AddProduct (Product product)
        {
            _productInOrder.Add(product);
        }

        //Create the FormattedOrder() method for how Order will be displayed
        public string FormattedOrder()
        {
            //Create decimal variable, assign it the return of the Subtotal() method
            decimal subtotal = Subtotal();
            //Create decimal variable, assign it the result of _tax times 100 
            decimal tax = _tax * 100;
            //Create decimal variable, assign it the return of the TotalTax() method passing it subtotal
            decimal totalTax = TotalTax(subtotal);
            //Create decimal variable, assign ti the return of the Total() method passing it subtotal
            decimal total = Total(subtotal);
            //Create int variable, assing it 0 for displaying how many prducts are in the Order
            int totalItems = 0;
            //Create string variable assing it no charaters
            string formatString = "";
            //adding to string variable with various words and variables, and new lines
            formatString += $"Order Number: {_orderNumber}\n";
            formatString += $"Customer Name: {_customerName}\n";
            formatString += $"\n";
            formatString += $"--Products--\n";
            //Loop through _productInzOrder List of products to display that list
            for (int i=0; i < _productInOrder.Count; i++)
            {
                //reassign int variable to i plus one, this will be how many products are List of products
                totalItems = i + 1;
                formatString += _productInOrder[i].ToString();
                
            }
            formatString += $"Items in Order: {totalItems} \n";
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
            //Loop through _productInOrder List adding Prodcut Prices together
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
            //format how customer name and order number will be displayed
            return $"{_customerName} - {_orderNumber}";
        }

    }//end of class

}//end of namespace
