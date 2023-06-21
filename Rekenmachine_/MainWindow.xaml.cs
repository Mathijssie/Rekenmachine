using System;
using System.Windows;
using System.Windows.Controls;

namespace Rekenmachine_
{
    public partial class MainWindow : Window
    {
        double temp = 0;
        string operation = "Minus";
        string output = "";
        bool isEqualPressed = false;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            Dividebtn.Content = "\u00F7";
            Sqrtbtn.Content = "\u221A";
            Squarebtn.Content = "x" + "\u00B2";
        }

        private void Numbtn_Click(object sender, RoutedEventArgs e)
        {
            if (isEqualPressed)
            {
                output = "";
                isEqualPressed = false;
            }

            string name = ((Button)sender).Name;
            Console.WriteLine("Object");

            switch (name)
            {
                case "Onebtn":
                    output += "1";
                    OutputTextBlock.Text = output;
                    break;

                case "Twobtn":
                    output += "2";
                    OutputTextBlock.Text = output;
                    break;

                case "Threebtn":
                    output += "3";
                    OutputTextBlock.Text = output;
                    break;

                case "Fourbtn":
                    output += "4";
                    OutputTextBlock.Text = output;
                    break;

                case "Fivebtn":
                    output += "5";
                    OutputTextBlock.Text = output;
                    break;

                case "Sixbtn":
                    output += "6";
                    OutputTextBlock.Text = output;
                    break;

                case "Sevenbtn":
                    output += "7";
                    OutputTextBlock.Text = output;
                    break;

                case "Eigthbtn":
                    output += "8";
                    OutputTextBlock.Text = output;
                    break;

                case "Ninebtn":
                    output += "9";
                    OutputTextBlock.Text = output;
                    break;

                case "Zerobtn":
                    output += "0";
                    OutputTextBlock.Text = output;
                    break;
                case "Decimalbtn":
                    if (!output.Contains(","))
                    {
                        output += ",";
                        OutputTextBlock.Text = output;
                    }
                    break;
            }
        }

        private void Minusbtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Minus";
                OutputTextBlock.Text = "-";
            }
        }

        private void Eqaulsbtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "" && !isEqualPressed)
            {
                double outputTemp;

                switch (operation)
                {
                    case "Minus":
                        outputTemp = temp - double.Parse(output);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;
                        break;

                    case "Plus":
                        outputTemp = temp + double.Parse(output);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;
                        break;

                    case "Product":
                        outputTemp = temp * double.Parse(output);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;
                        break;

                    case "Divide":
                        if (double.Parse(output) != 0)
                        {
                            outputTemp = temp / double.Parse(output);
                            output = outputTemp.ToString();
                            OutputTextBlock.Text = output;
                        }
                        break;
                }

                isEqualPressed = true;
            }
        }

        private void Plusbtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Plus";
                OutputTextBlock.Text = "+";
            }
        }

        private void Dividebtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Divide";
                OutputTextBlock.Text = "÷";
            }
        }

        private void Timesbtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Product";
                OutputTextBlock.Text = "x";
            }
        }

        private void Clearbtn_Click(object sender, RoutedEventArgs e)
        {
            output = "";
            OutputTextBlock.Text = output;
            isEqualPressed = false;
        }

        private void Sqaurebtn_Click(object sender, RoutedEventArgs e)
        {
            double square = double.Parse(output);
            output = (square * square).ToString();
            OutputTextBlock.Text = output;
        }

        private void Sqrtbtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                double sqrt = double.Parse(output);
                output = Math.Sqrt(sqrt).ToString();
                OutputTextBlock.Text = output;
            }
        }
    }
}
