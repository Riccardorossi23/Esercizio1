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

namespace Esercizio1WPF
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
        double max;
        double min;
        private void BtnCalcola_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            if (num1 < num2)
            {
                max = num2;
                min = num1;
            }
            else
            {
                max = num1;
                min = num2;
            }
            double media = (num1 + num2) / 2;
            lblMax.Content = $"{max}";
            lblMin.Content = $"{min}";
            lblMedia.Content = $"{media}";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Start.Content = $"inizio";
            txtNum1.IsEnabled = true;
            txtNum2.IsEnabled = true;
            lblMax.IsEnabled = true;
            lblMin.IsEnabled = true;
            lblMedia.IsEnabled = true;
            btnCalcola.IsEnabled = true;
        }
        private void Check_Unchecked(object sender, RoutedEventArgs e)
        {
            Start.Content = $"Fine";
            txtNum1.IsEnabled = false;
            txtNum2.IsEnabled = false;
            lblMax.IsEnabled = false;
            lblMin.IsEnabled = false;
            lblMedia.IsEnabled = false;
            btnCalcola.IsEnabled = false;
        }
    }
}
    
