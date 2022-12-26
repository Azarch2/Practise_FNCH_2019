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
    /// Логика взаимодействия для DriversWindow.xaml
    /// </summary>
    public partial class DriversWindow : Window
    {

        public static InspectionEntities db = new InspectionEntities();
        public DriversWindow()
        {
            InitializeComponent();
               GridOfDrivers.ItemsSource = db.Driver.ToList();
           // MyListVieTESTTEST.ItemsSource = db.Driver.ToList();
        }

        private void GoBackClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            ChooseWindow windowChoose = new ChooseWindow();
            windowChoose.Show();
        }

        public void UpdateThisBoxes()
        {

        }

        private void AddDriverClick(object sender, RoutedEventArgs e)
        {
            AddDriverWindow addDriverWindow = new AddDriverWindow(this);
            addDriverWindow.Show();
        }

        private void RedactDriverClick(object sender, RoutedEventArgs e)
        {
            Driver dv = (sender as Button).DataContext as Driver;
            ChangeUserWindow changeUserWindow = new ChangeUserWindow(this);
            changeUserWindow.textBoxId.Text = dv.Id.ToString();
            changeUserWindow.textBoxName.Text = dv.Name;
            changeUserWindow.textBoxMiddleName.Text = dv.MiddleName;
            changeUserWindow.textBoxSurname.Text = dv.Surname;
            changeUserWindow.textBoxNumberAndSerialPassport.Text = dv.PassportSerial.ToString() + dv.PassportNumber.ToString();
            changeUserWindow.textBoxRegistrationAddress.Text = dv.RegistrationAddress;
            changeUserWindow.textBoxResidentialAddress.Text = dv.ResidentialAddress;
            changeUserWindow.textBoxCompanyName.Text = dv.CompanyName;
            changeUserWindow.textBoxJobTitle.Text = dv.JobTitle;
            changeUserWindow.textBoxPhoneNumber.Text = dv.PhoneNumber;
            changeUserWindow.textBoxEmail.Text = dv.Email;
            ChangeUserWindow.PhotoOfDriver = dv.Photo;
            changeUserWindow.textBoxDescription.Text = dv.Description;
            changeUserWindow.Show();
        }
    }
}
