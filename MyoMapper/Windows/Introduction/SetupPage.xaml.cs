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

namespace MyoMapper.Windows.Introduction
{
    /// <summary>
    /// Interaction logic for SetupPage.xaml
    /// </summary>
    public partial class SetupPage : Page
    {

        int currentProcessNum = 1;

        public SetupPage()
        {
            InitializeComponent();
        }

        private void lblProcessNumber_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (currentProcessNum < 5)
            {
                ++currentProcessNum;
                imgHandPose.Source = new BitmapImage(new Uri($"../../Resources/HandImages/L-{currentProcessNum}.png", UriKind.Relative));
                Console.WriteLine(imgHandPose.Source.ToString());
                lblProcessNumber.Content = $"{currentProcessNum}/5";
            }
            else
            {
                lblProcessNumber.Visibility = Visibility.Hidden;
                btnFinish.Visibility = Visibility.Visible;
            }
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HELLO WORLD");
        }
    }
}
