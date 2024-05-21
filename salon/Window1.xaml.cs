using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using salon.UserControls;

namespace salon
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
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
            var contactCard = new ContactCard();
            Content.Children.Add(contactCard);
        }

        private void Services_OnClick(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            var servicsIcons = new List<Servic>();
            foreach (var i in Serialize.ShowService())
            {
                BitmapImage src = new BitmapImage();
                src.BeginInit();
                src.UriSource = new Uri(i.Img, UriKind.Relative);
                src.CacheOption = BitmapCacheOption.OnLoad;
                src.EndInit();
                Servic employerIcon = new Servic();
                employerIcon.ServiceImage.Source = src;
                employerIcon.ServiceNameText.Text = i.Name;
                employerIcon.ServicePriceText.Text = i.Cost;
                employerIcon.ServiceDurationText.Text = i.Duration;
                employerIcon.ServiceDescriptionText.Text = i.Description;
                
                servicsIcons.Add(employerIcon);
            }
            
            foreach (Servic i in servicsIcons)
            {
                Content.Children.Add(i);
            }
            
            
            
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var messageBoxResult = MessageBox.Show("Are you sure?", "", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
                
            }
        }

        private void Appointment_OnClick(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            var appointment = new Appointment();
            Content.Children.Add(appointment);
        }
    }
}
