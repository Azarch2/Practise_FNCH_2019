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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace InspectionPractice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static InspectionEntities db = new InspectionEntities();
        public static MainWindow thisWindow;
        public MainWindow()
        {
            InitializeComponent();
            thisWindow = this;
            foreach(var item in db.User)
            {
                if (item.CurrentTime > 0)
                {
                    AuthButton.IsEnabled = false;
                    var t = new Thread(() => TimerTick(item));
                    t.Start();
                    break;
                }
            }

         /* foreach(var item in db.Driver)
            {
                item.Photo = "Resources/" + item.Photo;
            }
            db.SaveChanges();*/

        }
        public void UpdatePhotoImgae()
        {
            foreach(Driver item in db.Driver)
            {
                item.PhotoImage = @"C:\Users\vbnf0\source\repos\InspectionPractice\InspectionPractice\Resources\001-happy-18.png";
            }
            db.SaveChanges();
        }
        private void Leave(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    

        public void TimerTick(User CurrentUser)
        {
            while (CurrentUser.CurrentTime > 0)
            {
                try
                {
                    Dispatcher.Invoke(new Action(() => AuthButton.IsEnabled = false));
                    Thread.Sleep(1000);
                    CurrentUser.CurrentTime -= 1;
                    db.SaveChanges();
                }
                catch
                {

                }
            }
            Dispatcher.Invoke(new Action(() => AuthButton.IsEnabled = true));
        }

        private void AuhtorizationClick(object sender, RoutedEventArgs e)
        {
            int check = 0;
            try
            {
                foreach(var item in db.User)
                {
                    if(item.Login == textboxLogin.Text && item.Password == textboxPassword.Password)
                    {
                        MessageBox.Show("Успешная авторизация");
                        ChooseWindow chooseWindow = new ChooseWindow();
                        this.Hide();
                        chooseWindow.Show();
                        check = 1;
                        break;
                    }

                    if (check == 0)
                    {
                        foreach (var CurrentUser in db.User)
                        {
                            if (CurrentUser.Login == textboxLogin.Text)
                            {
                                if (CurrentUser.CurrentTime == 0)
                                {
                                    

                                    if (CurrentUser.CountOfAuth >= 5)
                                    {
                                        MessageBox.Show("Вы превысили возможно количество попыток");
                                        CurrentUser.CurrentTime = 15;
                                        var t = new Thread(() => TimerTick(CurrentUser));
                                        t.Start();
                                        CurrentUser.CountOfAuth = 0;
                                        AuthButton.IsEnabled = false;
                                }
                                    else
                                    {
                                        CurrentUser.CountOfAuth++;
                                        MessageBox.Show("У вас осталось: " + (6 - CurrentUser.CountOfAuth) + " попытки");
                                        AuthButton.IsEnabled = true;
                                    }
                                    break;
                                }
                                else
                                {
                                    var t = new Thread(() => TimerTick(CurrentUser));
                                    t.Start();
                                }
                            }
                        }
                        MessageBox.Show("Данные для входа неверные!");
                    }
                }
                db.SaveChanges();
                textboxPassword.Password = "";
                textboxLogin.Text = "";
            }
            catch
            {
                MessageBox.Show("Не все поля были заполнены верно!");
            }
        }
    }
}
