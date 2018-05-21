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

namespace CorsoWpf.AsteroidRusset.WpfApp
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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void txtCurrentUser_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var device = e.Device;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.btnUpdate.IsEnabled = !this.btnUpdate.IsEnabled;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logout ?");
        }

        private void setValue_Click(object sender, RoutedEventArgs e)
        {
            this.lstNumbers.Items.Add(DateTime.Now.Millisecond);
        }
    }
}