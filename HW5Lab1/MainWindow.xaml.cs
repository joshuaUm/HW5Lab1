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

namespace HW5Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int TICKET_FINE = 60, MPH_SPEEDING_FEE = 7, SPEEDING_PENALTY = 250, PENALTY_LIMIT = 25;

   

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int speed = Int32.Parse(speedTextBox.Text);
            int speedLimit = Int32.Parse(speedLimitTextBox.Text);


            if(speed <= speedLimit)
            {
                statusTextBox.Content = "Legal Speed";
                canvasElement.Background = Brushes.Green;
            }
            else
            {
                int illegalSpeed = speed - speedLimit ;
                bool needsPenalty = illegalSpeed > PENALTY_LIMIT;

                int fine = illegalSpeed * MPH_SPEEDING_FEE + TICKET_FINE + (needsPenalty ? SPEEDING_PENALTY : 0);
                statusTextBox.Content = "Speeding"+ (needsPenalty ? " with " : "no")+ " penalty. (Fine : $" + fine  + ")" ;

                canvasElement.Background = needsPenalty ? Brushes.Red: Brushes.Yellow;


            }


        }
    }
}
