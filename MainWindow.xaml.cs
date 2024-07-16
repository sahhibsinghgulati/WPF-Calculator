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

        public MainWindow()
        {
            InitializeComponent();
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
                    output = output.Substring(0,output.Length-1);
                    Output.Text = output;
                    break;

            }
        }
    }
}