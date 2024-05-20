using System.Net.Sockets;
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
using salon.UserControls;

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

        private void Employer_OnClick(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            List<EmployerIcon> employerIcons = new List<EmployerIcon>();
            foreach (Employers i in Serialize.ShowEmployers())
            {
                EmployerIcon employerIcon = new EmployerIcon();
                employerIcon.EmployeeNameText.Text = i.Name;
                employerIcon.EmployeeAgeText.Text = i.Age;
                employerIcon.EmployeePositionText.Text = i.Possition;
                employerIcons.Add(employerIcon);
            }

            foreach (EmployerIcon i in employerIcons)
            {
                Content.Children.Add(i);
            }
        }

        private void Contact_OnClick(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            ContactCard contactCard = new ContactCard();
            Content.Children.Add(contactCard);
        }

        private void Services_OnClick(object sender, RoutedEventArgs e)
        {

            Services services = new Services();
            Content.Children.Add(services);
            
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void Appointment_OnClick(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            Appointment appointment = new Appointment();
            Content.Children.Add(appointment);
        }
    }
}