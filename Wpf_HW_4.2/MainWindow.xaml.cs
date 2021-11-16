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

namespace Wpf_HW_4._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Dollar(object sender, RoutedEventArgs e)
        {
            double ratedollar = Convert.ToDouble(rate.Text);
            double sumdollar = Convert.ToDouble(summ.Text);
            double resDouble = ratedollar * sumdollar;
            result.Text = resDouble.ToString();
        }
        private void Button_Euro(object sender, RoutedEventArgs e)
        {
            {
                double ratedollar = Convert.ToDouble(rate1.Text);
                double sumdollar = Convert.ToDouble(summ1.Text);
                double resDouble = ratedollar * sumdollar;
                result1.Text = resDouble.ToString();
            }
        }
        private void Button_uan(object sender, RoutedEventArgs e)
        {
            {
                double rateuan = Convert.ToDouble(rate2.Text);
                double sumuan = Convert.ToDouble(summ2.Text);
                double resDouble = rateuan * sumuan;
                result2.Text = resDouble.ToString();
            }
        }
        private void Button_Bit(object sender, RoutedEventArgs e)
        {
            double ratebit = Convert.ToDouble(rate3.Text);
            double sumbit = Convert.ToDouble(summ3.Text);
            double resDouble = ratebit * sumbit;
            result.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double ratemilimeter = Convert.ToDouble(rate4.Text);
            double resDouble = 0.001 * ratemilimeter;
            result4.Text = resDouble.ToString();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            {
                double ratefoot = Convert.ToDouble(rate5.Text);
                double resDouble = 0.3048 * ratefoot;
                result5.Text = resDouble.ToString();
            }
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            {
                double ratespan = Convert.ToDouble(rate6.Text);
                double resDouble = 0.2286 * ratespan;
                result6.Text = resDouble.ToString();
            }
        }
        private void Sagen(object sender, RoutedEventArgs e)
        {
            double ratesagen = Convert.ToDouble(rate7.Text);
            double resDouble = 2.48 * ratesagen;
            result7.Text = resDouble.ToString();
        }
    }
}
