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

namespace GitHubCalculator
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

        private void btnProcent_Click(object sender, RoutedEventArgs e)
        {
            int iNumberOne = Convert.ToInt32(txtNumberOne.Text);
            int iNumberTwo = Convert.ToInt32(txtNumberTwo.Text);
            int iResult = iNumberOne + iNumberTwo / 100;


            lblProcent.Content = iResult.ToString();
        }
    }
}
