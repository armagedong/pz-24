using System.IO;
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
        List<Appointment> UserservicsIcons = new List<Appointment>();
        public MainWindow()
        {
            InitializeComponent();
            Content.Children.Clear();
            var services = new Appointment();
            services.AppointmentTimeText.Text = "";
            Content.Children.Add(services);
        }

        private void Image_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            var login = new Login();
            Content.Children.Add(login);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void Employer_OnClick(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            
            var employerIcons = new List<EmployerIcon>();
            foreach (var i in Serialize.ShowEmployers())
            {
                byte[] decodedBytes = i.Img;
                // Создание изображения из массива байтов
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = new MemoryStream(decodedBytes);
                bitmapImage.EndInit();
                EmployerIcon employerIcon = new EmployerIcon();
                employerIcon.EmployeePhoto.Source = bitmapImage;
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
            var contactCard = new ContactCard();
            Content.Children.Add(contactCard);
        }

        private void Services_OnClick(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            UserservicsIcons.Clear();
            foreach (var i in Serialize.ShowService())
            {
                byte[] decodedBytes = i.Img;
                // Создание изображения из массива байтов
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = new MemoryStream(decodedBytes);
                bitmapImage.EndInit();
                Appointment AppIcon = new Appointment();
                AppIcon.AppointmentImage.Source = bitmapImage;
                AppIcon.AppointmentNameText.Text = i.Name;
                AppIcon.AppointmentPriceText.Text = i.Cost;
                AppIcon.AppointmentDurationText.Text = i.Duration;
                AppIcon.AppointmentTimeText.Text = "";
                
                UserservicsIcons.Add(AppIcon);
            }
            
            foreach (Appointment i in UserservicsIcons)
            {
                Content.Children.Add(i);
            }
            
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var messageBoxResult = MessageBox.Show("Are you sure?", "", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Close();
            }
        }
        
    }
}