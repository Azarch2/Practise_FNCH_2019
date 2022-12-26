using System;
using System.Collections.Generic;
using System.Linq;
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

namespace InspectionPractice
{
    /// <summary>
    /// Логика взаимодействия для ChooseWindow.xaml
    /// </summary>
    public partial class ChooseWindow : Window
    {

      
        public ChooseWindow()
        {
            InitializeComponent();
        }

        private void Leave(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow windowMain = new MainWindow();
            windowMain.Show();
        }

        private void GoToDriversClick(object sender, RoutedEventArgs e)
        {
            DriversWindow drivers = new DriversWindow();
            drivers.Show();
            this.Close();
        }

        private void GoToLicencesClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            LicenseWindow licenseWindow = new LicenseWindow();
            licenseWindow.Show();
        }
    }
}
