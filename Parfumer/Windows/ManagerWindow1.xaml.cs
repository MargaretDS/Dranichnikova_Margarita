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
using System.Windows.Shapes;

namespace Parfumer.Windows
{
    /// <summary>
    /// Логика взаимодействия для ManagerWindow1.xaml
    /// </summary>
    public partial class ManagerWindow1 : Window
    {
        public ManagerWindow1()
        {
            InitializeComponent();
        }

        private void ReturnMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.ShowDialog();
            this.Close();
        }
    }
}
