using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        string output="";
        double temp = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void numBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "OneBtn":
                output += "1";
                    Output.Text = output;
                    break;
                case "TwoBtn":
                    output += "2";
                    Output.Text = output;
                    break;
                case "ThreeBtn":
                    output += "3";
                    Output.Text = output;
                    break;
                case "FourBtn":
                    output += "4";
                    Output.Text = output;
                    break;
                case "FiveBtn":
                    output += "5";
                    Output.Text = output;
                    break;
                case "SixBtn":
                    output += "6";
                    Output.Text = output;
                    break;
                case "SevenBtn":
                    output += "7";
                    Output.Text = output;
                    break;
                case "EightBtn":
                    output += "8";
                    Output.Text = output;
                    break;
                case "NineBtn":
                    output += "9";
                    Output.Text = output;
                    break;
                case "ZeroBtn":
                    output += "0";
                    Output.Text = output;
                    break;
                case "DelBtn":
                    if (output.Length > 0)
                    {
                        output = output.Substring(0, output.Length - 1);
                        Output.Text = output;
                        break;
                    }
                    else
                        break;
                    //case "AddBtn":
                    //    output += "+";
                    //    Output.Text = output;
                    //    break;
                    //case "SubtractBtn":

                    //    break;
                    //case "MultiplyBtn":
                    //    output += "x";
                    //    Output.Text = output;
                    //    break;
                    //case "DivideBtn":
                    //    output += "/";
                    //    Output.Text = output;
                    //    break;

            }
        }

        private void SubtractBtn_Click(object sender, RoutedEventArgs e)
        {   
            if (output != "")
            {
                temp = double.Parse(output);
            }
            output = "";
            operation = "-";

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if(output != "")
            {
                temp = double.Parse(output);
            }
            output = "";
            operation = "+";
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            switch(operation) {
                case "+":
                    output = (temp + double.Parse(output)).ToString();
                    Output.Text = output;
                    break;
                case "-":
                    output = (temp - double.Parse(output)).ToString();
                    Output.Text = output;
                    break;
                case "x":
                    output = (temp * double.Parse(output)).ToString();
                    Output.Text = output;
                    break;
                case "/":
                    output = (temp / double.Parse(output)).ToString();
                    Output.Text = output;
                    break;
            }
        }

        private void MultiplyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
            }
            output = "";
            operation = "x";

        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
            }
            output = "";
            operation = "/";

        }
    }
}