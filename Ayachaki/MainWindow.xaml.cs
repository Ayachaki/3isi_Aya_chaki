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

namespace Ayachaki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (IsValidForm())
            {
                // The submit button was clicked and the form is valid.

            }
            else
            {
                // The form is invalid.

            }
        }

        private bool IsValidForm()
        {

            if (string.IsNullOrEmpty(age.Text))


                {
                return false;
            }

            return true;
        }
    
    }
}