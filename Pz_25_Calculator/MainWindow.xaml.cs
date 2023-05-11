using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Pz_25_Calculator
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
        private void press0Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputTextBlock.Text == "0")
            {
                inputTextBlock.Text = null;
            }
            inputTextBlock.Text += "0";
        }
        private void press1Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputTextBlock.Text == "0")
            {
                inputTextBlock.Text = null;
            }
            inputTextBlock.Text += "1";
        }
        private void press2Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputTextBlock.Text == "0")
            {
                inputTextBlock.Text = null;
            }
            inputTextBlock.Text += "2";
        }
        private void press3Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputTextBlock.Text == "0")
            {
                inputTextBlock.Text = null;
            }
            inputTextBlock.Text += "3";
        }
        private void press4Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputTextBlock.Text == "0")
            {
                inputTextBlock.Text = null;
            }
            inputTextBlock.Text += "4";
        }
        private void press5Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputTextBlock.Text == "0")
            {
                inputTextBlock.Text = null;
            }
            inputTextBlock.Text += "5";
        }
        private void press6Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputTextBlock.Text == "0")
            {
                inputTextBlock.Text = null;
            }
            inputTextBlock.Text += "6";
        }
        private void press7Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputTextBlock.Text == "0")
            {
                inputTextBlock.Text = null;
            }
            inputTextBlock.Text += "7";
        }
        private void press8Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputTextBlock.Text == "0")
            {
                inputTextBlock.Text = null;
            }
            inputTextBlock.Text += "8";
        }
        private void press9Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputTextBlock.Text == "0")
            {
                inputTextBlock.Text = null;
            }
            inputTextBlock.Text += "9";
        }
        private void pressplusButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "+";
        }
        private void pressminusButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "-";
        }
        private void pressmultButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "*";
        }
        private void pressshareButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "/";
        }
        private void pressequalButton_Click(object sender, RoutedEventArgs e)
        {
            string exptession = inputTextBlock.Text;
            inputTextBlock.Text = Calculation(exptession).ToString();
        }
        private double Calculation(string expression)
        {
            Regex regex = new Regex(@"([-+]?\d*\.?\d+)([+\-*/])([-+]?\d*\.?\d+)");
            MatchCollection matches = regex.Matches(expression);
            double result = 0;
            foreach (Match match in matches)
            {
                double left = double.Parse(match.Groups[1].Value);
                double right = double.Parse(match.Groups[3].Value);
                string op = match.Groups[2].Value;
                switch (op)
                {
                    case "+":
                        result = left + right;
                        break;
                    case "-":
                        result = left - right;
                        break;
                    case "*":
                        result = left * right;
                        break;
                    case "/":
                        result = left / right;
                        break;
                }
                expression = expression.Replace(match.Value, result.ToString());
            }
            try
            {
                return double.Parse(expression);
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный формат");
                return double.NaN;
            }
        }
        private void pressdeleteButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text = "";
        }
    }
}