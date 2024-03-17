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

namespace APBD
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Button 1 Click");
            Output.Text = "Button 1 used";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Button 2 Click");
            Output.Text = "Button 2 used";
        }

        

        private void Calculate_Average(object sender, RoutedEventArgs e)
        {
            String[] strings = numbers.Text.Split(',');
            int[] tab = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                tab[i] = int.Parse(strings[i]);
            }
            
            int sum = 0;
            foreach (int item in tab)
            {
                sum += item;
            }
            int avg = sum / tab.Length;
            Output.Text = avg.ToString();
            Console.WriteLine(avg);
        }

       private void Calculate_Max(object sender, RoutedEventArgs e)
        {
            String[] strings = numbers.Text.Split(',');
            int[] tab = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                tab[i] = int.Parse(strings[i]);
            }

            int max = 0;
            foreach (int item in tab)
            {
                if (item > max) { max = item; }
            }
            
            Output.Text = max.ToString();
            Console.WriteLine(max);
        }
    }
}
