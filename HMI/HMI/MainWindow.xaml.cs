﻿/*
* FILE : MainWindow.cs
* PROJECT : PROG3165 - User Interface Design  - A04
* PROGRAMMERS : Lev Cocarell and Bobby Vu
* FIRST VERSION : 2018-04-12
* DESCRIPTION :
* This file contains the source code for the 
*/

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

namespace HMI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Automatically resize height and width relative to content
            this.SizeToContent = SizeToContent.WidthAndHeight;
            tabItem_Manual.IsEnabled = false;


  
        }

     
        private void button_stop_Click(object sender, RoutedEventArgs e)
        {
            tabItem_Manual.IsEnabled = true;
            this.tabItem_Manual.Focus();
        }
    }
}
