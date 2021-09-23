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

namespace LommeRegner2
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

        private Boolean DoStuff() 
        {
            var isNumeric = double.TryParse(box1.Text, out double n);
            if (isNumeric == true)
            {
                isNumeric = double.TryParse(box2.Text, out double f);
            }
            if (isNumeric == true)
            {
                return true;
            }return false;
            
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            var d = DoStuff();
            if (box1.Text != null && box2.Text != null && d == true)
            {
                double Tal = double.Parse(box1.Text) + double.Parse(box2.Text);
                Textbox1.Text = Tal + "";
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            var d = DoStuff();
            if (box1.Text != null && box2.Text != null && d == true)
            {
                double Tal = double.Parse(box1.Text) - double.Parse(box2.Text);
                Textbox1.Text = Tal + "";
            }
        }

        private void Gange_Click(object sender, RoutedEventArgs e)
        {
            var d = DoStuff();
            if (box1.Text != null && box2.Text != null && d == true)
            {
                double Tal = double.Parse(box1.Text) * double.Parse(box2.Text);
                Textbox1.Text = Tal + "";
            }
        }

        private void Divider_Click(object sender, RoutedEventArgs e)
        {
            var d = DoStuff();
            if (box1.Text != null && box2.Text != null && d == true)
            {
                double Tal = double.Parse(box1.Text) / double.Parse(box2.Text);
                Textbox1.Text = Tal + "";
            }
        }

        private void TextBox_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_3(object sender, TextChangedEventArgs e)
        {

        }
    }
}
