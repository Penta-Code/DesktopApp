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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Converter myConverter = new Converter(84, 99, 2);

        string kursValut = $"Текущий курс валют: 84";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(myConverter), "Текущий курс валют");
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (soms.Text == string.Empty)
                MessageBox.Show("Вы не ввели сумму!");
            int amount = Convert.ToInt32(soms.Text);
            myConverter.BuyUSD(amount);
            MessageBox.Show(Convert.ToString(myConverter.BuyUSD(amount)), "Результат операции");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(soms.Text);
            myConverter.BuyEUR(amount);
            MessageBox.Show(Convert.ToString(myConverter.BuyEUR(amount)), "Результат операции");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(soms.Text);
            myConverter.BuyRUB(amount);
            MessageBox.Show(Convert.ToString(myConverter.BuyRUB(amount)), "Результат операции");
        }

        private void textBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(currency.Text);
            myConverter.SellUSD(amount);
            MessageBox.Show(Convert.ToString(myConverter.SellUSD(amount)), "Результат операции");
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(currency.Text);
            myConverter.SellEUR(amount);
            MessageBox.Show(Convert.ToString(myConverter.SellEUR(amount)), "Результат операции");
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(currency.Text);
            myConverter.SellRUB(amount);
            MessageBox.Show(Convert.ToString(myConverter.SellRUB(amount)), "Результат операции");
        }
    }
}
