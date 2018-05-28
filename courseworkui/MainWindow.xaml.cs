using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DAL;
using DAL.Models;

namespace courseworkui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window //початкове вікно з логуванням
    {
        Methods Methods = new Methods();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e) //кнопка входу
        {
            string login = textbox1.Text;
            string password = passwordbox1.Password;
            UserUI userUI = await Task.Run(() =>
            {
                return Methods.ValidateUser(login, password);
            });
            if (userUI != null)
            {
                DealerWindow dealerWindow = new DealerWindow();
                dealerWindow.SetUser(userUI);
                this.Visibility = Visibility.Hidden;
                dealerWindow.ShowDialog();
                userUI = null;
            }
            else
                textbox1.Text = "Wrong login/password!";
            this.Visibility = Visibility.Visible;

        }

        private void Register(object sender, RoutedEventArgs e) //кнопка на реєстрацію нового користувача
        {
            this.Visibility = Visibility.Hidden;
            RegisterWindow registerWindow = new RegisterWindow(); //створюється екземпляр вікна реєстрації
            registerWindow.ShowDialog(); //відкриття вікна реєстрації
            this.Visibility = Visibility.Visible;
        }
    }
}
