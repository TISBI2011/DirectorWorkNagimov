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
using director.Moduls;

namespace director.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }


        private void BRegister_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage(new User()));
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.User.FirstOrDefault(u => u.Login == TBLogin.Text);
            if (user == null || user.Password != TBPassword.Text)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
           
            NavigationService.Navigate(new KinoPage());
        }
    }
}
