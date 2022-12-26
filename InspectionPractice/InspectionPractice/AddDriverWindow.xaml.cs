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
    /// Логика взаимодействия для AddDriverWindow.xaml
    /// </summary>
    public partial class AddDriverWindow : Window
    {
        public static string PhotoOfDriver = "";
        public static InspectionEntities db = new InspectionEntities();
        public DriversWindow windowDrivers;
        public AddDriverWindow(DriversWindow windowDrivers)
        {
            InitializeComponent();
            this.windowDrivers = windowDrivers;
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

        private void AddDriverClick(object sender, RoutedEventArgs e)
        {
            int check = 0;
            string PassportSerial = "";
            string PassportNumber = "";
            if (textBoxId.Text != "" && textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxMiddleName.Text != "" && textBoxNumberAndSerialPassport.Text != "" && textBoxRegistrationAddress.Text != "" && textBoxResidentialAddress.Text != "" && textBoxPhoneNumber.Text != "" && textBoxEmail.Text != "")
            {
                if (PhotoOfDriver != "")
                {
                    int checker = 0;
                    foreach(User us in db.User)
                    {
                        if (us.Id == int.Parse(textBoxId.Text))
                        {
                            MessageBox.Show("Copy");
                            checker = 1;
                            break;
                        }
                    }
                    if (checker == 0)
                    {
                        if (textBoxNumberAndSerialPassport.Text.Length == 9)
                        {
                            try
                            {
                                Driver driver = new Driver();
                                driver.Id = int.Parse(textBoxId.Text);
                                driver.Surname = textBoxSurname.Text;
                                driver.Name = textBoxName.Text;
                                driver.MiddleName = textBoxName.Text;
                                driver.PassportSerial = int.Parse(textBoxNumberAndSerialPassport.Text.Substring(0, 4));
                                // PassportNumber += int.Parse(textBoxNumberAndSerialPassport.Text.Substring(4));
                                driver.PassportNumber = int.Parse(textBoxNumberAndSerialPassport.Text.Substring(4));
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
                                    db.Driver.Add(driver);
                                }
                                else if (check == 1)
                                {
                                    MessageBox.Show("Вы не выбрали фотографию.");
                                }

                                db.SaveChanges();
                                PhotoOfDriver = "";
                                windowDrivers.GridOfDrivers.ItemsSource = db.Driver.ToList();
                                MessageBox.Show("Вы успешно добавили водителя!");
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Возникла непредвиденная ошибка.");
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Серия и номер должны состоять из 9 цифр");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Такой Id уже существует!");
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали фотографию");
                }
            }
            else
            {
                MessageBox.Show("Вы заполнили не все поля");
            }
        }

        private void Leave(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
