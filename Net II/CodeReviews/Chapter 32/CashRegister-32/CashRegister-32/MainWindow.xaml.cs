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

namespace CashRegister_32
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            txt1.Text  = "1";
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txt1.Text = "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txt1.Text = "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            txt1.Text = "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            txt1.Text = "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            txt1.Text = "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            txt1.Text = "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            txt1.Text = "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            txt1.Text = "9";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            txt1.Text = "0";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            txt1.Text = ".";
        }

        private void Button_Click_Enter(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
           
            txt1.Clear();
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            txt1.Text = txt1.Text.Remove(txt1.Text.Length - 1);
        }

        
        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txt1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt1.Text = txt1.Text.Remove(txt1.Text.Length - 1);
            }
         }
    }
}
