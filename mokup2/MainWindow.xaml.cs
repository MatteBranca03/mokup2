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

namespace mokup2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sld1.Minimum = 0;
            sld1.Maximum = 100;
            sld2.Minimum = 0;
            sld2.Maximum = 100;
        }

        private void sld1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int v = (int)sld1.Value;
            txtNumero1.Text = v.ToString();
            int c = (int)sld2.Value;
            int somma = c + v;
            txtSomma.Text = somma.ToString();
        }

        private void sld2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int v = (int)sld2.Value;
            txtNumero2.Text = v.ToString();
            int c = (int)sld1.Value;
            int somma = c + v;
            txtSomma.Text = somma.ToString();

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            sld1.IsEnabled = true;
            sld2.IsEnabled = true; 
        }
    }
}
