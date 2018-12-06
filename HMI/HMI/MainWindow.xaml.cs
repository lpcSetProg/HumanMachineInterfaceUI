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
        int vol = 0;

        public MainWindow()
        {
            InitializeComponent();
            // Automatically resize height and width relative to content
            this.SizeToContent = SizeToContent.WidthAndHeight;
            tabItem_Manual.IsEnabled = false;
            tabItem_SHUTDOWN.IsEnabled = false;
         
            initiliazeHMI();

          

  
        }

     
        private void button_stop_Click(object sender, RoutedEventArgs e)
        {
            // grey out control buttons
            button_StartProcess_the2nd.Background = Brushes.LightGray;

            button_stop_the2nd.Background = Brushes.LightGray;

            button_shutDownProcess_the2nd.Background = Brushes.LightGray;

            button_shutDownProcess_the2nd.IsEnabled = false;


            button_StartProcess.IsEnabled = false;
            button_StartProcess_the2nd.IsEnabled = false;


            button_stop_the2nd.IsEnabled = false;
            tabItem_Line.IsEnabled   = false;
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

            vol = 20000;




        }

        private void button_start_Hopper_Click(object sender, RoutedEventArgs e)
        {
           
                



        }

        private void button_StartProcess_Click(object sender, RoutedEventArgs e)
        {


            textBox_FillHeadsCount.Text = vol.ToString();

            vol = vol - 1000;

            textBox_LabelsPresent.Text = "YES";

       
            textBox_FillHeadLocation.Text = "UP";


            textBox_CanWeight.Text = "3900";

            textBox_Sealer.Text = "10";

            textBox_PackerStatus.Text = "Clear";

            textBox_CasePacker.Text = "1";

            textBox_PalletStatus.Text = "Found";       

            incre = incre + 10;

            textBox_CanCount.Text = incre.ToString();

        

            if (Enumerable.Range(1, 39).Contains(incre))
            {
                button_warning_hopper.Background = Brushes.Chartreuse;
                button_warning_fill_heads.Background = Brushes.Chartreuse;
                button_warning_weight_station.Background = Brushes.Chartreuse;
                button_warning_sealer.Background = Brushes.Chartreuse;
                button_warning_labeler.Background = Brushes.Chartreuse;
                button_warning_case_packer.Background = Brushes.Chartreuse;



                button_warning_hopper.Content = "RUNNING";
                button_warning_fill_heads.Content = "RUNNING";
                button_warning_weight_station.Content = "RUNNING";
                button_warning_sealer.Content = "RUNNING";
                button_warning_labeler.Content = "RUNNING";
                button_warning_case_packer.Content = "RUNNING";


            }
            else if (Enumerable.Range(40, 119).Contains(incre))
            {
                button_warning_hopper.Content = "WARNING";
                button_warning_hopper.Background = Brushes.Yellow;
            }
            else if (Enumerable.Range(120, 121).Contains(incre))
            {
                button_warning_hopper.Content = "STOPPED";
                button_warning_hopper.Background = Brushes.Red;
           
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_status_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void button_shutDownProcess_Click(object sender, RoutedEventArgs e)
        {
            tabItem_Line.IsEnabled = false;
            tabItem_Manual.IsEnabled = false;
            tabItem_SHUTDOWN.IsEnabled = true;
            this.tabItem_SHUTDOWN.Focus();

        }

        private void button_StartProcess_ShutDownScreen_Click(object sender, RoutedEventArgs e)
        {
            tabItem_Line.IsEnabled = true;
            tabItem_Manual.IsEnabled = false;
            tabItem_SHUTDOWN.IsEnabled = false;
            this.tabItem_Line.Focus();
            initiliazeHMI();
        }

        private void button_shutDownProcess_the2nd_Click(object sender, RoutedEventArgs e)
        {
            tabItem_Line.IsEnabled = false;
            tabItem_Manual.IsEnabled = false;
            tabItem_SHUTDOWN.IsEnabled = true;
            this.tabItem_SHUTDOWN.Focus();
        }

        private void button_confirmation_Click(object sender, RoutedEventArgs e)
        {
            //button_StartProcess_the2nd.Background = Brushes.DodgerBlue;
            tabItem_Manual.IsEnabled = false;
            button_StartProcess.IsEnabled = true;
            tabItem_Line.IsEnabled = true;
            button_stop_the2nd.IsEnabled = true;
            this.tabItem_Line.Focus();
        }
    }
}
