﻿using ITI_System.Management.Services;
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

namespace ITI_System.Management.Forms
{
    /// <summary>
    /// Interaction logic for FrmAccount.xaml
    /// </summary>
    public partial class FrmAccount : Window
    {
        AccountServices ACC = new AccountServices();
        public FrmAccount()
        {
            InitializeComponent();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ACC.AddAcount(this);
            
        }
    }
}
