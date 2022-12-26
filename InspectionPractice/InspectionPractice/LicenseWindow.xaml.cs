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
    /// Логика взаимодействия для LicenseWindow.xaml
    /// </summary>
    public partial class LicenseWindow : Window
    {
        public static InspectionEntities db = new InspectionEntities();
        public LicenseWindow()
        {
            InitializeComponent();
            foreach (var item in db.License)
            {
                item.allCategories = "";
               foreach (var itemInLicense in item.LicenseCategory)
                {
                    item.allCategories += itemInLicense.Id + ", ";
                }
            }
     
            GridOfLicenses.ItemsSource = db.License.ToList();
            
        }

        private void AddLicenseClick(object sender, RoutedEventArgs e)
        {
            AddLicenseWindow addLicenseWindow = new AddLicenseWindow(this);
            addLicenseWindow.Show();
        }

        private void GoBackClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            ChooseWindow chooseWindow = new ChooseWindow();
            chooseWindow.Show();
        }

        private void EnterMouse(object sender, MouseEventArgs e)
        {
            if ((sender as ComboBox).Items.Count <= 0)
            {
             //   License license = (sender as ComboBox).DataContext as License;
              //  (sender as ComboBox).ItemsSource = license.LicenseCategory.ToList();
               // MessageBox.Show("licensecategory: " + license.LicenseCategory.ToList()[0].Id);
            }
        }
    }
}
