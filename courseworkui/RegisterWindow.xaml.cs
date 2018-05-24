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
using DAL;
using DAL.Models;
using MahApps.Metro.Controls;

namespace courseworkui
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        Methods Methods = new Methods();

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            //RegisterWindow registerWindow = new RegisterWindow();
            //registerWindow.ShowDialog();
            string login = textbox1.Text;
            decimal.TryParse(textbox2.Text, out decimal balance);
            string password = passwordbox1.Password;
            UserUI userUI = new UserUI() { Login = login, Password = password, Balance = balance };
            Methods.AddUser(userUI);
            this.Close();
        }
    }
}
