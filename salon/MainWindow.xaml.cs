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

namespace salon
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

        public object NewButton_Click { get; private set; }

        private void Image_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            Login login = new Login();
            Content.Children.Add(login);
            Window1 window1 = new Window1();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}