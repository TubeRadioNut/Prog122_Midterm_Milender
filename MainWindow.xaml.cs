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
        Inventory inventory = new Inventory();
        public MainWindow()
        {
            InitializeComponent();

            Product coffee = new Product("Dark", 3.50m);
            Product tea = new Product("Black", 2.50m);
            Order testOrder = new Order();
            testOrder.AddProduct(coffee);
            testOrder.AddProduct(tea);

            rtbDisplayCurrentOrder.Text = testOrder.FormattedOrder();

        }//end of MainWindow


    }//end of partial class


}//end of namespace