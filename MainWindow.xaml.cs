/*Cameron Heinz
 * March 26, 2019
 * texting translations
 */
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

namespace _312639TXTMSG
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

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            int numbOfLines = txtInput.LineCount;
            for (int i = 0; i <= numbOfLines; i++)
            {
                
                if (txtInput.Text.ToUpper() == "CU" || txtInput.Text.ToUpper() == "CU\r\n")
                {
                    lblOutput.Content = "SEE YOU";
                }

                else if (txtInput.Text.ToUpper() == "SEE YOU" || txtInput.Text.ToUpper() == "SEE YOU\r\n")
                {
                    lblOutput.Content = "CU";
                }

                if (txtInput.Text.ToUpper() == ";-)" || txtInput.Text.ToUpper() == ";-)\r\n")
                {
                    lblOutput.Content = "WINK";
                }
                else if (txtInput.Text.ToUpper() == "WINK" || txtInput.Text.ToUpper() == "WINK\r\n")
                {
                    lblOutput.Content = ";-)";
                }

                if (txtInput.Text.ToUpper() == ":-)" || txtInput.Text.ToUpper() == ":-)\r\n")
                {
                    lblOutput.Content = "I'M HAPPY";
                }
                else if (txtInput.Text.ToUpper() == "I'M HAPPY" || txtInput.Text.ToUpper() == "I'M HAPPY\r\n")
                {
                    lblOutput.Content = ":-)";
                }

                if (txtInput.Text.ToUpper() == ":-(" || txtInput.Text.ToUpper() == ":-(\r\n")
                {
                    lblOutput.Content = "I'M UNHAPPY";
                }
                else if (txtInput.Text.ToUpper() == "I'M UNHAPPY" || txtInput.Text.ToUpper() == "I'M UNHAPPY\r\n")
                {
                    lblOutput.Content = ":-(";
                }

                if (txtInput.Text.ToUpper() == ":-P" || txtInput.Text.ToUpper() == ":-P\r\n")
                {
                    lblOutput.Content = "STICK OUT MY TOUNG";
                }
                else if (txtInput.Text.ToUpper() == "STICK OUT MY TOUNG" || txtInput.Text.ToUpper() == "STICK OUT MY TOUNG\r\n")
                {
                    lblOutput.Content = ":-P";
                }

                if (txtInput.Text.ToUpper() == "˜.˜" || txtInput.Text.ToUpper() == "˜.˜\r\n")
                {
                    lblOutput.Content = "SLEEPY";
                }
                else if (txtInput.Text.ToUpper() == "SLEEPY" || txtInput.Text.ToUpper() == "SLEEPY\r\n")
                {
                    lblOutput.Content = "˜.˜";
                }

                if (txtInput.Text.ToUpper() == "TA" || txtInput.Text.ToUpper() == "TA\r\n")
                {
                    lblOutput.Content = "TOTALLY AWESOME";
                }
                else if (txtInput.Text.ToUpper() == "TOTALLY AWESOME" || txtInput.Text.ToUpper() == "TOTALLY AWESOME\r\n")
                {
                    lblOutput.Content = "TA";
                }

                if (txtInput.Text.ToUpper() == "CCC" || txtInput.Text.ToUpper() == "CCC\r\n")
                {
                    lblOutput.Content = "CANADIAN COMPUTING COMPITITION";
                }
                else if (txtInput.Text.ToUpper() == "CANADIAN COMPUTING COMPITITION" || txtInput.Text.ToUpper() == "CANADIAN COMPUTING COMPITITION\r\n")
                {
                    lblOutput.Content = "CCC";
                }

                if (txtInput.Text.ToUpper() == "CUZ" || txtInput.Text.ToUpper() == "CUZ\r\n")
                {
                    lblOutput.Content = "BECAUSE";
                }
                else if (txtInput.Text.ToUpper() == "BECAUSE" || txtInput.Text.ToUpper() == "BECAUSE\r\n")
                {
                    lblOutput.Content = "CUZ";
                }

                if (txtInput.Text.ToUpper() == "TY" || txtInput.Text.ToUpper() == "TY\r\n")
                {
                    lblOutput.Content = "THANK YOU";
                }
                else if (txtInput.Text.ToUpper() == "THANK YOU" || txtInput.Text.ToUpper() == "THANK YOU\r\n")
                {
                    lblOutput.Content = "TY";
                }

                if (txtInput.Text.ToUpper() == "YW" || txtInput.Text.ToUpper() == "YW\r\n")
                {
                    lblOutput.Content = "YOU'RE WELCOME";
                }
                else if (txtInput.Text.ToUpper() == "YOU'RE WELCOME" || txtInput.Text.ToUpper() == "YOU'RE WELCOME\r\n")
                {
                    lblOutput.Content = "YW";
                }

                if (txtInput.Text.ToUpper() == "TTYL" || txtInput.Text.ToUpper() == "TTYL\r\n")
                {

                    if (txtInput.Text.ToUpper() == "TTYL" || txtInput.Text.ToUpper() == "TTYL\r\n")
                    {
                        lblOutput.Content = "TALK TO YOU LATER";
                    }
                    else if (txtInput.Text.ToUpper() == "TALK TO YOU LATER" || txtInput.Text.ToUpper() == "TALK TO YOU LATER\r\n")
                    {
                        lblOutput.Content = "TTYL";
                    }
                    

                    this.Close();

                }
            }
            
        }
    }
}
