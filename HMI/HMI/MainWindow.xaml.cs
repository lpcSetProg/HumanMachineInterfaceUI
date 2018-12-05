/*
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

namespace HMI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int incre = 0;

        public MainWindow()
        {
            InitializeComponent();
            // Automatically resize height and width relative to content
            this.SizeToContent = SizeToContent.WidthAndHeight;
            tabItem_Manual.IsEnabled = false;
            initiliazeHMI();

          

  
        }

     
        private void button_stop_Click(object sender, RoutedEventArgs e)
        {
            tabItem_Manual.IsEnabled = true;
            this.tabItem_Manual.Focus();
        }

 


        public void initiliazeHMI()
        {
            button_warning_hopper.Background = Brushes.White;
            button_warning_fill_heads.Background = Brushes.White;
            button_warning_weight_station.Background = Brushes.White;
            button_warning_sealer.Background = Brushes.White;
            button_warning_labeler.Background = Brushes.White;
            button_warning_case_packer.Background = Brushes.White;

            textBox_NameStation.Text = "CASE PACKER";
            textBox_status.Text = "DOWN";
            textBox_StartTime.Text = "14:24";
            textBox_StopTime.Text = "17:44";
            textBox_eventDuration.Text = "14:24 to 18:02";




        }

        private void button_start_Hopper_Click(object sender, RoutedEventArgs e)
        {
           
                



        }

        private void button_StartProcess_Click(object sender, RoutedEventArgs e)
        {

            incre = incre + 1;
            textBox_CanCount.Text = incre.ToString();

            if (Enumerable.Range(1, 39).Contains(incre))
            {
                button_warning_hopper.Background = Brushes.Green;
                button_warning_fill_heads.Background = Brushes.Green;
                button_warning_weight_station.Background = Brushes.Green;
                button_warning_sealer.Background = Brushes.Green;
                button_warning_labeler.Background = Brushes.Green;
                button_warning_case_packer.Background = Brushes.Green;



            }
            else if (Enumerable.Range(40, 119).Contains(incre))
            {
                button_warning_hopper.Background = Brushes.Yellow;
            }
            else if (Enumerable.Range(120, 121).Contains(incre))
            {
                button_warning_hopper.Background = Brushes.Red;
                button_start_Hopper.IsEnabled = false;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_status_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }
    }
}
