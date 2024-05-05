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

            //Assign previousOrders to combo box ItemsSource
            cmbChooseOrder.ItemsSource = previousOrder;

            //Assign currentOrder Product list to combo box to remove product
            cmbChooseProductToRemove.ItemsSource = currentOrder.PorductInOrder;
            //Testing classes 
            //Product coffee = new Product("Dark", 3.50m);
            //Product tea = new Product("Black", 2.50m);
            //Order testOrder = new Order();
            //testOrder.AddProduct(inventory.CoffeeProducts[0]);
            //testOrder.AddProduct(inventory.TeaProducts[2]);

            //rtbDisplayCurrentOrder.Text = testOrder.FormattedOrder();

        }//end of MainWindow

        private void btnCoffeeDark_Click(object sender, RoutedEventArgs e)
        {
            //For every Product Button ( Dark, Green, Fruit, etc... )
            //Add the selected product to the current order list ( use the .AddProduct(Product) method you created )
            //Display the FormattedOrder() to the Rich Text Box for the current order
            //Product coffeDark = inventory.CoffeeProducts[0];
            currentOrder.AddProduct(inventory.CoffeeProducts[0]);
            rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();

            cmbChooseProductToRemove.Items.Refresh();
        }

        private void btnCoffeeMedium_Click(object sender, RoutedEventArgs e)
        {
            //For every Product Button ( Dark, Green, Fruit, etc... )
            //Add the selected product to the current order list ( use the .AddProduct(Product) method you created )
            //Display the FormattedOrder() to the Rich Text Box for the current order
            //Product coffeeMedium = inventory.CoffeeProducts[1];
            currentOrder.AddProduct(inventory.CoffeeProducts[1]);
            rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();

            cmbChooseProductToRemove.Items.Refresh();
        }

        private void btnCoffeeLight_Click(object sender, RoutedEventArgs e)
        {
            //For every Product Button ( Dark, Green, Fruit, etc... )
            //Add the selected product to the current order list ( use the .AddProduct(Product) method you created )
            //Display the FormattedOrder() to the Rich Text Box for the current order
            //Product coffeeLight = inventory.CoffeeProducts[2];
            currentOrder.AddProduct(inventory.CoffeeProducts[2]);
            rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();

            cmbChooseProductToRemove.Items.Refresh();
        }

        private void btnTeaBlack_Click(object sender, RoutedEventArgs e)
        {
            //For every Product Button ( Dark, Green, Fruit, etc... )
            //Add the selected product to the current order list ( use the .AddProduct(Product) method you created )
            //Display the FormattedOrder() to the Rich Text Box for the current order
            //Product teaBlack = inventory.TeaProducts[0];
            currentOrder.AddProduct(inventory.TeaProducts[0]);
            rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();

            cmbChooseProductToRemove.Items.Refresh();
        }

        private void btnTeaGreen_Click(object sender, RoutedEventArgs e)
        {
            //For every Product Button ( Dark, Green, Fruit, etc... )
            //Add the selected product to the current order list ( use the .AddProduct(Product) method you created )
            //Display the FormattedOrder() to the Rich Text Box for the current order
            //Product teaGreen = inventory.TeaProducts[1];
            currentOrder.AddProduct(inventory.TeaProducts[1]);
            rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();

            cmbChooseProductToRemove.Items.Refresh();
        }

        private void btnTeaChai_Click(object sender, RoutedEventArgs e)
        {
            //For every Product Button ( Dark, Green, Fruit, etc... )
            //Add the selected product to the current order list ( use the .AddProduct(Product) method you created )
            //Display the FormattedOrder() to the Rich Text Box for the current order
            //Product teaChai = inventory.TeaProducts[2];
            currentOrder.AddProduct(inventory.TeaProducts[2]);
            rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();

            cmbChooseProductToRemove.Items.Refresh();
        }

        private void btnBrkfstSandwitch_Click(object sender, RoutedEventArgs e)
        {
            //For every Product Button ( Dark, Green, Fruit, etc... )
            //Add the selected product to the current order list ( use the .AddProduct(Product) method you created )
            //Display the FormattedOrder() to the Rich Text Box for the current order
            //Product brkfstSandwitch = inventory.BreakfastProducts[0];
            currentOrder.AddProduct(inventory.BreakfastProducts[0]);
            rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();

            cmbChooseProductToRemove.Items.Refresh();
        }

        private void btnBrkfstPastry_Click(object sender, RoutedEventArgs e)
        {
            //For every Product Button ( Dark, Green, Fruit, etc... )
            //Add the selected product to the current order list ( use the .AddProduct(Product) method you created )
            //Display the FormattedOrder() to the Rich Text Box for the current order
            //Product brkfstPasty = inventory.BreakfastProducts[1];
            currentOrder.AddProduct(inventory.BreakfastProducts[1]);
            rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();

            cmbChooseProductToRemove.Items.Refresh();
        }

        private void BrkfstFruit_Click(object sender, RoutedEventArgs e)
        {
            //For every Product Button ( Dark, Green, Fruit, etc... )
            //Add the selected product to the current order list ( use the .AddProduct(Product) method you created )
            //Display the FormattedOrder() to the Rich Text Box for the current order
            //Product brkfstFruit = inventory.BreakfastProducts[2];
            currentOrder.AddProduct(inventory.BreakfastProducts[2]);
            rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();

            cmbChooseProductToRemove.Items.Refresh();
        }

        private void btnCompleteOder_Click(object sender, RoutedEventArgs e)
        {
            //Complete Order Button
            //Get user input for Name on currentOrder
            string customerName = txtCustomerName.Text;
            //Check if there is a user name entered
            bool isNotEmpty = customerName.Length != 0;
            bool areProductsInOrder = AreProductsInOrder();

            if (areProductsInOrder)
            {
                //If true
                //Refresh the combo box info with comboBoxName.Items.Refresh() // If it works you should see the last order appear
                //in the drop down when you click on it
                if (isNotEmpty)
                {
                    //Add name to order
                    currentOrder.CustomerName = customerName;
                    //Add current order to previous order list
                    previousOrder.Add(currentOrder);
                    //Create a new instance of Order for currentOrder
                    currentOrder = new Order();
                    //Clear name box
                    txtCustomerName.Text = "";
                    //Clear rich text box
                    rtbDisplayCurrentOrder.Text = "";
                    //Refresh the combo box info with comboBoxName.Items.Refresh() // If it works you should see the last order appear
                    //in the drop down when you click on it
                    cmbChooseOrder.Items.Refresh();

                }
                //else
                //Show a message box saying to enter a name
                else
                {
                    MessageBox.Show("Enter Customer Name");
                }

            }
            else
            {
                MessageBox.Show("There are not Products in this order");
            }
            
            
        }

        private void cmbChooseOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Combo Box Selection Changed Event
            //When the user selects an order display the FormattedOrder() to the previous order Rich Text Box
            Order selectedOrder = cmbChooseOrder.SelectedItem as Order;
            rtbDisplayPreviousOrder.Text = selectedOrder.FormattedOrder();
        }

        private void btnRemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            int selectedProduct = cmbChooseProductToRemove.SelectedIndex;

            if (selectedProduct != -1)
            {
                currentOrder.PorductInOrder.Remove(currentOrder.PorductInOrder[selectedProduct]);

                rtbDisplayCurrentOrder.Text = currentOrder.FormattedOrder();

                cmbChooseProductToRemove.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Select Product to Remove");
            }

        }

        public bool AreProductsInOrder()
        {
            bool areProcductsInOrder = currentOrder.PorductInOrder.Count != 0;
            return areProcductsInOrder;
            
        }
    }//end of partial class


}//end of namespace














