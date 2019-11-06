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
    /// Interaction logic for HelloPage.xaml
    /// </summary>
    public partial class HelloPage : Page
    {

        public HelloPage()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            //Frame frame = Window.GetWindow(this).Content as Frame;
            //frame.Navigate(new Uri("Windows/Introduction/SetupPage.xaml", UriKind.Relative));
            NavigationService.Navigate(new Uri("Windows/Introduction/SetupPage.xaml", UriKind.Relative));
        }
    }
}
