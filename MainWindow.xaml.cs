/*Cameron Heinz
 * March 29
 * Convert time from Ottawa time to other noth amarican time zones
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

namespace _312639GoodTimes
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string time = txtInput.Text;
            int.TryParse(time, out int OttawaTime);

            int Victoria = OttawaTime - 300;
            int Edmonton = OttawaTime - 200;
            int winnipeg = OttawaTime - 100;
            int Toronto = OttawaTime;
            int Halifax = OttawaTime + 100;
            int StJohns = OttawaTime + 130;

            if(StJohns >= 2459)
            {
                StJohns = StJohns -= 2400;
            }
            if (StJohns % 100 > 59) StJohns = StJohns -60 + 100;

            if(Victoria <= 0)
            {
                Victoria = Victoria += 2400;
            }
            if (Victoria % 100 > 59) Victoria = Victoria - 60 + 100;

            if(Edmonton <= 0)
            {
                Edmonton = Edmonton += 2400;
            }
            if (Edmonton % 100 > 59) Edmonton = Edmonton - 60 + 100;

            if(winnipeg <= 0)
            {
                winnipeg = winnipeg += 2400;
            }
            if (winnipeg % 100 > 59) winnipeg = winnipeg - 60 + 100;

            if(Halifax >= 2400)
            {
                Halifax = Halifax -= 2400;
            }
            if (Halifax % 100 > 59) Halifax = Halifax - 60 + 100;

            if (Toronto % 100 > 59) Toronto = Toronto - 60 + 100;
                
            lblOutout.Content = "The time in Victoria is " + Victoria.ToString() + Environment.NewLine + "The time in Edmonton is " + Edmonton.ToString() + Environment.NewLine + "Teh time in Winnipeg is " + winnipeg.ToString() + Environment.NewLine + "The Time in Toronto is " + Toronto.ToString() + Environment.NewLine + "The time in Halifax is " + Halifax.ToString() + Environment.NewLine + "The time in St Johns is " + StJohns.ToString() + Environment.NewLine;
        }
    }
}
