﻿using System;
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
using WpfAppPractwork1.Pages;

namespace WpfAppPractwork1
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

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            WindowPassword passwordWindow = new WindowPassword();

            if (passwordWindow.ShowDialog() == true)
            {
                if (passwordWindow.Password == "1234")
                {
                    MessageBox.Show("Авторизация пройдена");
                    ClassFrame.frmObj = FrmMain;
                    ClassFrame.frmObj.Navigate(new PageMain());
                }

                else
                    MessageBox.Show("Неверный пароль");
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена");
            }
        }
    }
}
