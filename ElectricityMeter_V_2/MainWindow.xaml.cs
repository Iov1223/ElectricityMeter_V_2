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
using System.Text.RegularExpressions;

namespace ElectricityMeter_V_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Button> buttonList;
        public MainWindow()
        {
            InitializeComponent();
            buttonList = new List<Button>();
        }
        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9\\,]+");
            if (e.Handled = regex.IsMatch(e.Text))
            {
                MessageBox.Show("\t         НЕКОРРЕКТНЫЙ ВВОД:\nтолко целые или вещественные числа (через запятую)!");
            }
        }
        private void searchSum(TextBox _night, TextBox _day, Button _sum)
        {
            double _tmp;
            if (textBoxNightPrice.Text == "" | textBoxDayPrice.Text == "")
            {
                if (_night.Text == "" | _day.Text == "")
                {
                    MessageBox.Show("Не хватает данных!");
                }
                else
                {
                    _tmp = (Convert.ToDouble(_night.Text) + (Convert.ToDouble(_day.Text))) * 5.15;
                    _sum.Content = _tmp.ToString("0.00");
                }
            }
            else
            {
                _tmp = (Convert.ToDouble(_night.Text) * Convert.ToDouble(textBoxNightPrice.Text)) + (Convert.ToInt32(_day.Text) * Convert.ToDouble(textBoxDayPrice.Text));
                _sum.Content = _tmp.ToString("0.00");
            }
        }
        private void buttonJanuary_Click(object sender, RoutedEventArgs e)
        {
            searchSum(textBoxNightJanuary, textBoxDayJanuary, buttonlJanuary);
            buttonList.Add(buttonlJanuary);
        }

        private void buttonFebruary_Click(object sender, RoutedEventArgs e)
        {
            searchSum(textBoxNightFebruary, textBoxDayFebruary, buttonFebruary);
            buttonList.Add(buttonFebruary);
        }

        private void buttonMarch_Click(object sender, RoutedEventArgs e)
        {
            searchSum(textBoxNightMarch, textBoxDayMarch, buttonMarch);
            buttonList.Add(buttonMarch);
        }

        private void buttonApril_Click(object sender, RoutedEventArgs e)
        {
            searchSum(textBoxNightApril, textBoxDayApril, buttonApril);
            buttonList.Add(buttonApril);
        }

        private void buttonMay_Click(object sender, RoutedEventArgs e)
        {
            searchSum(textBoxNightMay, textBoxDayMay, buttonMay);
            buttonList.Add(buttonMay);
        }
        private void buttonJune_Click(object sender, RoutedEventArgs e)
        {
            searchSum(textBoxNightJune, textBoxDayJune, buttonJune);
            buttonList.Add(buttonJune);
        }
        private void buttonJuly_Click(object sender, RoutedEventArgs e)
        {
            searchSum(textBoxNightJuly, textBoxDayJuly, buttonJuly);
            buttonList.Add(buttonJuly);
        }

        private void buttonAugust_Click(object sender, RoutedEventArgs e)
        {
            searchSum(textBoxNightAugust, textBoxDayAugust, buttonAugust);
            buttonList.Add(buttonAugust);
        }

        private void buttonSeptember_Click(object sender, RoutedEventArgs e)
        {
            searchSum(textBoxNightSeptember, textBoxDaySeptember, buttonSeptember);
            buttonList.Add(buttonSeptember);
        }

        private void buttonOctober_Click(object sender, RoutedEventArgs e)
        {
            searchSum(textBoxNightOctober, textBoxDayOctober, buttonOctober);
            buttonList.Add(buttonOctober);
        }

        private void buttonNovember_Click(object sender, RoutedEventArgs e)
        {
            searchSum(textBoxNightNovember, textBoxDayNovember, buttonNovember);
            buttonList.Add(buttonNovember);
        }

        private void buttonDecember_Click(object sender, RoutedEventArgs e)
        {
            searchSum(textBoxNightDecember, textBoxDayDecember, buttonDecember);
            buttonList.Add(buttonDecember);
        }

        private void buttonTotal_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxNightPrice.Text == "" | textBoxDayPrice.Text == "")
            {
                MessageBox.Show("Если в строке \"ТАРИФ\" не введёно " +
                                "\nоба коэффицента, итоговая сумма " +
                                "\nбудет посчитана по среднему значению." +
                                "\nСредний тариф = 5,15 руб за кВт.ч");
            }
            double sum = 0;
            for (int i = 0; i < buttonList.Count; i++)
            {
                if (buttonList[i].Content.ToString() != "Посчитать")
                {
                    sum += Convert.ToDouble(buttonList[i].Content);
                }
            }
            labelSum.Content = sum.ToString();
        }
        private void buttonMiddlePrice_Click(object sender, RoutedEventArgs e)
        {
            
            if (textBoxNightPrice.Text == "" | textBoxDayPrice.Text == "")
            {
                MessageBox.Show("Не хватает данных!");
            }
            else
            {
                buttonMiddlePrice.Content = ((Convert.ToDouble(textBoxNightPrice.Text) + Convert.ToDouble(textBoxDayPrice.Text)) / 2).ToString();
            }

        }
    }
}
