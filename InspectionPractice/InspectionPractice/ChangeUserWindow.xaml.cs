using Microsoft.Win32;
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
    /// Логика взаимодействия для ChangeUserWindow.xaml
    /// </summary>
    public partial class ChangeUserWindow : Window
    {
        DriversWindow driversWindow1;
        public static string PhotoOfDriver = "";

        public static InspectionEntities db = new InspectionEntities();
        public ChangeUserWindow(DriversWindow driversWindow)
        {
            InitializeComponent();
            driversWindow1 = driversWindow;
        }

        private void ChangeDriverClick(object sender, RoutedEventArgs e)
        {
            int check = 0;
            string PassportSerial = "";
            string PassportNumber = "";
            if (textBoxId.Text != "" && textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxMiddleName.Text != "" && textBoxNumberAndSerialPassport.Text != "" && textBoxRegistrationAddress.Text != "" && textBoxResidentialAddress.Text != "" && textBoxPhoneNumber.Text != "" && textBoxEmail.Text != "")
            {
                try
                {
                    Driver driver = new Driver();
                    driver.Id = int.Parse(textBoxId.Text);
                    driver.Surname = textBoxSurname.Text;
                    driver.Name = textBoxName.Text;
                    driver.MiddleName = textBoxName.Text;
                    driver.PassportSerial = int.Parse(textBoxNumberAndSerialPassport.Text.Substring(0, 4));
                    PassportNumber += int.Parse(textBoxNumberAndSerialPassport.Text.Substring(4));
                    driver.PassportNumber = int.Parse(PassportNumber);
                    driver.Postcode = 420000;
                    driver.RegistrationAddress = textBoxRegistrationAddress.Text;
                    driver.ResidentialAddress = textBoxResidentialAddress.Text;
                    driver.CompanyName = textBoxCompanyName.Text;
                    driver.JobTitle = textBoxJobTitle.Text;
                    driver.PhoneNumber = textBoxPhoneNumber.Text;
                    driver.Email = textBoxEmail.Text;

                    if (PhotoOfDriver != "")
                    {
                    driver.Photo = PhotoOfDriver;
                    }
                    else
                    {
                        check = 1;
                    }
                    driver.Description = textBoxDescription.Text;

                    if (check == 0)
                    {
                        foreach(var item in db.Driver)
                        {
                            if(item.Id == int.Parse(textBoxId.Text))
                            {
                                item.Surname = textBoxSurname.Text;
                                item.Name = textBoxName.Text;
                                item.MiddleName = textBoxName.Text;
                                item.PassportSerial = int.Parse(textBoxNumberAndSerialPassport.Text.Substring(0, 4));
                                item.PassportNumber = int.Parse(PassportNumber);
                                item.Postcode = 420000;
                                item.RegistrationAddress = textBoxRegistrationAddress.Text;
                                item.ResidentialAddress = textBoxResidentialAddress.Text;
                                item.CompanyName = textBoxCompanyName.Text;
                                item.JobTitle = textBoxJobTitle.Text;
                                item.PhoneNumber = textBoxPhoneNumber.Text;
                                item.Email = textBoxEmail.Text;
                                 item.Description = textBoxDescription.Text;
                            item.Photo = PhotoOfDriver;
                            break;
                            }
                        }
                    }
                    else if (check == 1)
                    {
                        MessageBox.Show("Вы не выбрали фотографию.");
                    }
             
                    db.SaveChanges();
                    driversWindow1.GridOfDrivers.ItemsSource = db.Driver.ToList();
                    MessageBox.Show("Вы успешно изменили водителя!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Возникла непредвиденная ошибка.");
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void Leave(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ChoosePhotoClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == true) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    PhotoOfDriver = open_dialog.FileName;

                    MessageBox.Show("Вы выбрали фотографию" + PhotoOfDriver);
                }
                catch
                {
                    MessageBox.Show("Возникла ошибка");
                }
            }
        }
    }
}
