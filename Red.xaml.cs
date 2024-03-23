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

namespace ZiminaPractic
{
    /// <summary>
    /// Логика взаимодействия для Red.xaml
    /// </summary>
    public partial class Red : Window
    {
        public Red()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            var login = log.Text;
            var password = pass.Text;
            var email = mail.Text;
            var context = new AppaDbContext();
            var user_exist = context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
            if (user_exist != null)
            {
                MessageBox.Show("Такой пользователь уже существует");
                return;
            }
            var user = new User { Login = login, Password = password };
            context.Users.Add(user);
            context.SaveChanges();

            MessageBox.Show("Добро пожаловать!");
        }
    }
}
