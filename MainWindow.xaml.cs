/*Cameron Heinz
 * March 29
 * Designed a T-Shirt using rectangles and Elipses.
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

namespace _312639_T_Shirt_Drawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Rectangle c = new Rectangle();
            canvas.Children.Add(c);
            c.Fill = Brushes.Yellow;
            c.Height = 250;
            c.Width = 200;
            Canvas.SetLeft(c, 150);
            Canvas.SetTop(c, 60);

            Ellipse a = new Ellipse();
            canvas.Children.Add(a);
            a.Fill = Brushes.White;
            a.Height = 100;
            a.Width = 100;
            Canvas.SetTop(a, 0);
            Canvas.SetLeft(a, 200);

           


            for (int i = 7; i > 0; i--)
            {

                Rectangle z = new Rectangle();
                z.Height = i * 25;
                z.Width = i * 25;
                if (i % 2 == 0)
                {
                    z.Fill = Brushes.Blue;
                }
                else
                {
                    z.Fill = Brushes.Red;
                }

                canvas.Children.Add(z);
                Canvas.SetTop(z, 200 - (z.Width / 2));
                Canvas.SetLeft(z, 250 - (z.Width / 2));

                Ellipse e = new Ellipse();
                canvas.Children.Add(e);
                e.Height = i * 25;
                e.Width = i * 25;
                if (i % 2 == 0)
                {
                    e.Fill = Brushes.Red;
                }
                else
                {
                    e.Fill = Brushes.Blue;
                }

                Canvas.SetTop(e, 200 - ( e.Width / 2));
                Canvas.SetLeft(e, 250 - ( e .Width / 2));

                
            }

            }
        }
}
