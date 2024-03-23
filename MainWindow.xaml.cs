﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ZiminaPractic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() 
        {
            InitializeComponent();
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            var login = log.Text;
            var password = password.Text;
            var context = new AppaDbContext();
            var user_exist = context.Users.FirstOrDefault(x=>x.Login == login && x.Password == password);
            if (user_exist != null) 
            {
                MessageBox.Show("Неправильный логин или пароль");
                return;
            }
            MessageBox.Show("Вы успешно вошли в аккаунт")

        }

        private void ToReg_Click(object sender, RoutedEventArgs e)
        {
           Registration registration = new Registration();
            registration.Show();
            this.Hide();

        }
    }
}
