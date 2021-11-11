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

namespace Practice_6
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            Pair firstPair = new Pair(int.Parse(FIRSTP1.Text), int.Parse(SECONDP1.Text));
            Pair secondPair = new Pair(int.Parse(FIRSTP2.Text), int.Parse(SECONDP2.Text));
            Pair resultPair = firstPair.Substract(secondPair);
            result.Text = (resultPair.First, resultPair.Second).ToString();
        }

        private void ComparisonPair_Click(object sender, RoutedEventArgs e)
        {
            Pair pair = new Pair(int.Parse(FIRSTP1.Text), int.Parse(SECONDP1.Text));
            if (pair)
                result.Text = "true";
            else result.Text = "false";
        }
        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Золотарев М. А.\n Группа: ИСП-34\n Вариант №13", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
