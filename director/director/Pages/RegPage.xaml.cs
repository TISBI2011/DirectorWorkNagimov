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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        User contextUser;
        public RegPage(User user)
        {
            InitializeComponent();
            contextUser = user;
            DataContext = contextUser;
        }

        private void BRegister_Click(object sender, RoutedEventArgs e)
        {
            if (contextUser.Id == 0)
                App.DB.User.Add(contextUser);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        
    }
}
