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
    /// Логика взаимодействия для AddLicenseWindow.xaml
    /// </summary>
    public partial class AddLicenseWindow : Window
    {

        public static InspectionEntities db = new InspectionEntities();
        public LicenseWindow licenseWindow;
        public AddLicenseWindow(LicenseWindow licenseWindow)
        {
            InitializeComponent();
            this.licenseWindow = licenseWindow;
            comboBoxDriver.ItemsSource = db.Driver.ToList();
            comboBoxStatus.ItemsSource = db.LicenseState.ToList();
            comboBoxCategories.ItemsSource = db.LicenseCategory.ToList();
            
        }

        private void Leave(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddLicenseClick(object sender, RoutedEventArgs e)
        {
            if (DateStart.SelectedDate != null && DateEnd.SelectedDate !=null && TextBoxSeries.Text != "" && textBoxNumber.Text != "" && comboBoxDriver.SelectedItem != null && comboBoxStatus.SelectedItem !=null)
            {
                try
                {
                    if (TextBoxSeries.Text.Length <= 5)
                    {
                        License license = new License();
                        license.LicenseDate = (DateTime)DateStart.SelectedDate;
                        license.ExpireDate = (DateTime)DateEnd.SelectedDate;
                        license.LicenseSeries = TextBoxSeries.Text;
                        license.LicenseNumber = int.Parse(textBoxNumber.Text);
                        license.Driver = comboBoxDriver.SelectedItem as Driver;
                        license.LicenseState = comboBoxStatus.SelectedItem as LicenseState;
                        license.LicenseCategory.Add(comboBoxCategories.SelectedItem as LicenseCategory);
                        db.License.Add(license);
                        db.SaveChanges();
                        licenseWindow.GridOfLicenses.ItemsSource = db.License.ToList();
                        MessageBox.Show("Вы успешно добавили водительское удостоверение!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Длина серии не должна превышать 5 символов");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка.");
                    MessageBox.Show(ex.Message);
                    
                }
            }
            else
            {
                MessageBox.Show("Вы заполнили не все поля");
            }
        }
    }
}
