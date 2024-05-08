//Charles Milender
//5-3-2024
//Programminng 122
//Midterm
using Prog122_Midterm_Milender;
using System.Numerics;
using System.Security.Claims;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_Midterm_Milender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creates List of Product named previousOrder that will hold a List of Product that was created by the user
        List<Order> previousOrder = new List<Order>();
        //Initializing an instance of Inventory named inventory
        Inventory inventory = new Inventory();
        //Delaring an instance of Order named currentOrder that will hold a list of Product will be created by the user
        Order currentOrder;


        public MainWindow()
        {
            InitializeComponent();//<---Don't delete this and keep it at the top of the MainWindow()
          
            //initialize a new Order() named currentOrder
            currentOrder = new Order();

            //Assign previousOrders to combo box to display completed orders
            cmbChooseOrder.ItemsSource = previousOrder;

            //Assign currentOrder Product list to combo box to remove product
            cmbChooseProductToRemove.ItemsSource = currentOrder.ProductInOrder;

            //Testing classes 
            //Product coffee = new Product("Dark", 3.50m);
            //Product tea = new Product("Black", 2.50m);
            //Order testOrder = new Order();
            //testOrder.AddProduct(inventory.CoffeeProducts[0]);
            //testOrder.AddProduct(inventory.TeaProducts[2]);
            //rtbDisplayCurrentOrder.Text = testOrder.FormattedOrder();


        }//end of MainWindow
        
        //Create button click event for dark coffee button
        private void btnCoffeeDark_Click(object sender, RoutedEventArgs e)
        {
            //Creates bools for radio buttons
            bool small = rbSmall.IsChecked.Value;
            bool medium = rbMedium.IsChecked.Value;
            bool large = rbLarge.IsChecked.Value;
            //Testing which, if any, radio button is selected with if/else statements
            if (small)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.CoffeeProducts[0]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            else if (medium)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.CoffeeProducts[1]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            else if(large)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.CoffeeProducts[2]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            //only get here if no radio button is selected
            else
            {
                //Alert user to select a size
                MessageBox.Show("Select a Size");
            }

        }//end of btnCoffeeDark_Click()

        //Create button click event for medium coffee button
        private void btnCoffeeMedium_Click(object sender, RoutedEventArgs e)
        {
            //Creates bools for radio buttons
            bool small = rbSmall.IsChecked.Value;
            bool medium = rbMedium.IsChecked.Value;
            bool large = rbLarge.IsChecked.Value;
            //Testing which, if any, radio button is selected with if/else statements
            if (small)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.CoffeeProducts[3]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            else if (medium)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.CoffeeProducts[4]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            else if (large)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.CoffeeProducts[5]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            //only get here if no radio button is selected
            else
            {
                //Alert user to select a size
                MessageBox.Show("Select a Size");
            }
        }//end of btnCoffeeMedium_Click()

        //Create click event for light coffee button
        private void btnCoffeeLight_Click(object sender, RoutedEventArgs e)
        {
            //Creates bools for radio buttons
            bool small = rbSmall.IsChecked.Value;
            bool medium = rbMedium.IsChecked.Value;
            bool large = rbLarge.IsChecked.Value;
            //Testing which, if any, radio button is selected with if/else statements
            if (small)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.CoffeeProducts[6]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            else if (medium)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.CoffeeProducts[7]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            else if (large)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.CoffeeProducts[8]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            //only get here if no radio button is selected
            else
            {
                //Alert user to select a size
                MessageBox.Show("Select a Size");
            }
        }//end of btnCoffeeLight_Click()

        //Create click event for black tea button
        private void btnTeaBlack_Click(object sender, RoutedEventArgs e)
        {
            //Creates bools for radio buttons
            bool small = rbSmall.IsChecked.Value;
            bool medium = rbMedium.IsChecked.Value;
            bool large = rbLarge.IsChecked.Value;
            //Testing which, if any, radio button is selected with if/else statements
            if (small)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.TeaProducts[0]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            else if (medium)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.TeaProducts[1]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            else if (large)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.TeaProducts[2]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            //only get here if no radio button is selected
            else
            {
                //Alert user to select a size
                MessageBox.Show("Select a Size");
            }
        }//end of btnTeaBlack_Click()


        //Create click event for green tea button
        private void btnTeaGreen_Click(object sender, RoutedEventArgs e)
        {
            //Creates bools for radio buttons
            bool small = rbSmall.IsChecked.Value;
            bool medium = rbMedium.IsChecked.Value;
            bool large = rbLarge.IsChecked.Value;
            //Testing which, if any, radio button is selected with if/else statements
            if (small)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.TeaProducts[3]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            else if (medium)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.TeaProducts[4]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            else if (large)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.TeaProducts[5]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            //only get here if no radio button is selected
            else
            {
                //Alert user to select a size
                MessageBox.Show("Select a Size");
            }
        }//end of btnTeaGreen_Click

        //Create click event for chai tea button
        private void btnTeaChai_Click(object sender, RoutedEventArgs e)
        {
            //Creates bools for radio buttons
            bool small = rbSmall.IsChecked.Value;
            bool medium = rbMedium.IsChecked.Value;
            bool large = rbLarge.IsChecked.Value;
            //Testing which, if any, radio button is selected with if/else statements
            if (small)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.TeaProducts[6]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            else if (medium)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.TeaProducts[7]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            else if (large)
            {
                //Adding product from inventory class to current order List of products
                currentOrder.AddProduct(inventory.TeaProducts[8]);
                //display currentOrder List of products in rich text box
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box for remove item
                cmbChooseProductToRemove.Items.Refresh();
            }
            //only get here if NO radio button is selected
            else
            {
                //Alert user to select a size
                MessageBox.Show("Select a Size");
            }
        }//end of btnTeaChai_Click()

        //Creates click event for breakfast sandwich button
        private void btnBrkfstSandwitch_Click(object sender, RoutedEventArgs e)
        {
            //Adding product from inventory class to current order List of products
            //I am not sure why we did this in the midterm review , but it works both ways
            //Product brkfstSandwitch = inventory.BreakfastProducts[0];
            currentOrder.AddProduct(inventory.BreakfastProducts[0]);
            //Display currentOder List of products in rich text box
            rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
            //Refresh combo box for remove item
            cmbChooseProductToRemove.Items.Refresh();
        }//end of btnBrkfstSandwitch_Click()

        //Create click event for breakfast pastry button
        private void btnBrkfstPastry_Click(object sender, RoutedEventArgs e)
        {
            //Adding product form invetory class to current order List of products
            //Product brkfstPasty = inventory.BreakfastProducts[1];
            currentOrder.AddProduct(inventory.BreakfastProducts[1]);
            //Display currentOrder List of products in rich text box
            rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
            //Refresh combo box for remove item
            cmbChooseProductToRemove.Items.Refresh();
        }//end of btnBrkfstPastry_Click()

        //Create click event for breakfast fruit button
        private void BrkfstFruit_Click(object sender, RoutedEventArgs e)
        {
            //Adding product from invetory class to current order List of products
            //Product brkfstFruit = inventory.BreakfastProducts[2];
            currentOrder.AddProduct(inventory.BreakfastProducts[2]);
            //Display currentOrder List of products in rich text box
            rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
            //Refesh combo box for remove item
            cmbChooseProductToRemove.Items.Refresh();
        }//end of BrkfstFruit_Click()

        //Create click event for complete order button
        private void btnCompleteOder_Click(object sender, RoutedEventArgs e)
        {
            //Get user input for Name on currentOrder
            string customerName = txtCustomerName.Text;
            //Create bool to check if there is a user name entered
            bool isNotEmpty = customerName.Length != 0;
            //Create bool and assign it the result of test: current order list of Products count is not equal to 0
            bool areProductsInOrder = currentOrder.ProductInOrder.Count != 0;
            //Testing if there are products in the currentOrder List of products
            if (areProductsInOrder)
            {
                //testing if there is a Name entered for currentOrder
                if (isNotEmpty)
                {
                    //Adding Name to currentOrder
                    currentOrder.CustomerName = customerName;
                    //Add current order to previous order list
                    previousOrder.Add(currentOrder);
                    //Create a new instance of Order for currentOrder for next order
                    currentOrder = new Order();
                    //Clear name text box
                    txtCustomerName.Text = "";
                    //Clear rich text box
                    rtbDisplayCurrentOrder.Text = "";
                    //Refesh combo box for completed orders updating it with updated previousOrder List of Orders
                    cmbChooseOrder.Items.Refresh();
                    //Create int variable assign it the index of the last order added to the previousOrder List
                    int indexAutoDisplay = previousOrder.Count - 1;
                    //Display the last order added to the previousOrder List in the combo box and rich text box for completed order 
                    cmbChooseOrder.SelectedIndex = indexAutoDisplay;
                    //Clearing the combo box and assign it to the new instance of Order()
                    cmbChooseProductToRemove.ItemsSource = currentOrder.ProductInOrder;
                    //I thought this would clear the combo box since there is now no list in the currentOrder, but it did not work
                    //cmbChooseProductToRemove.Items.Refresh();

                }
                //only get here if NO Name is entered
                //Alert user there is NO Name entered with MessageBox
                else
                {
                    MessageBox.Show("Enter Customer Name");
                }

            }
            //Only get here if there are NO products in currentOrder List of products
            //Alert user there are NO products in the current order
            else
            {
                MessageBox.Show("There are no Products in this order");
            }


        }//end of btnCompleteOder_Click()

        //Create click event for combo box chooseOrder 
        private void cmbChooseOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Creating Order variable, assign it selected item in combo box, make sure computer knows it is an Order
            Order selectedOrder = cmbChooseOrder.SelectedItem as Order;
            //Display selcted order from combo box to rich text box previous orders
            rtbDisplayPreviousOrder.Text = selectedOrder.FormattedOrder();
        }//end of cmbChooseOrder_SelectionChanged()

        //Create click event for combo box remove product
        private void btnRemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            //Create an int variable and assign it the index of the selected prodcut from currentOrder List of products
            int selectedProduct = cmbChooseProductToRemove.SelectedIndex;
            //Testing if user selected a product from combo box
            if (selectedProduct != -1)
            {
                //Remove selected product using built in Remove() method using int variable 
                currentOrder.ProductInOrder.Remove(currentOrder.ProductInOrder[selectedProduct]);
                //Display updated currentOrder List of products
                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();
                //Refresh combo box with updated cuurentOrder List of products
                cmbChooseProductToRemove.Items.Refresh();
            }
            //only get here if NO product is selected in combo box
            //Alert user to select a product
            else
            {
                MessageBox.Show("Select Product to Remove");
            }

        }//end of btnRemoveProduct_Click()

    }//end of partial class


}//end of namespace














