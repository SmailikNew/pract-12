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
using System.Windows.Threading;

namespace pract_12
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

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП - 34, Горшков Илья, Вариант 2.Реализовать расчет задачи:" +
                " Даны стороны прямоугольника a и b. Найти его площадь периметр." +
                 " Дано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево.");
        }

        private void calculate(object sender, RoutedEventArgs e)
        {
            if (number.Text != "")
            {
                number.Focus();
                string result = number.Text;
                rez.Text = $"{result[2]}" + $"{result[1]}" + $"{result[0]}";
            }
            else MessageBox.Show("Введите значение!");
        }

        private void find(object sender, RoutedEventArgs e)
        {
            if (sidea.Text != "" && sideb.Text != "")
            {
                sidea.Focus();
                square.Text = (int.Parse(sidea.Text) * int.Parse(sideb.Text)).ToString();
                perimetr.Text = ((int.Parse(sidea.Text) + int.Parse(sideb.Text)) * 2).ToString();
            }
            else MessageBox.Show("Введите значение!");
        }

        private void Sidea_TextChanged(object sender, TextChangedEventArgs e)
        {
            square.Clear();
            perimetr.Clear();
        }

        private void Sideb_TextChanged(object sender, TextChangedEventArgs e)
        {
            square.Clear();
            perimetr.Clear();
        }

        private void Number_TextChanged(object sender, TextChangedEventArgs e)
        {
            rez.Clear();
        }

        private void Timertick(object sender, EventArgs e)
        {
            tbdata.Text = DateTime.Now.ToString("dd.MM.yyyy");
            tbtime.Text = DateTime.Now.ToString("HH.mm.ss");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += Timertick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }

        private void clear(object sender, RoutedEventArgs e)
        {
            number.Clear();
            rez.Clear();
            sidea.Clear();
            sideb.Clear();
            square.Clear();
            perimetr.Clear();
        }
    }
}
