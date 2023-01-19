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
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
                MessageBox.Show("Неверный ввод (толко целые числа)!");
            }
        }
        private void searchSum(TextBox _one, TextBox _two, Button _sum)
        {
            if (_one.Text != null && _two.Text != null)
            {
                _sum.Content = (Convert.ToInt32(_one.Text) * 2.86) + (Convert.ToInt32(_two.Text) * 7.36);
            }
            else
            {
                MessageBox.Show("Не хватает данных!");
            }
        }
        private void buttonlJanuary_Click(object sender, RoutedEventArgs e)
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
    }
}
