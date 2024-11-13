using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            TitelAppearsAbove();

        }

        private void TitelAppearsAbove()
        {
            Random rnd = new Random();
            string[] TitelAppears = new string[] { "rood", "geel", "groen", "oranje", "wit", "blauw" };
            string TitelAppears1 = TitelAppears[rnd.Next(0, TitelAppears.Length)];
            string TitelAppears2 = TitelAppears[rnd.Next(0, TitelAppears.Length)];
            string TitelAppears3 = TitelAppears[rnd.Next(0, TitelAppears.Length)];
            string TitelAppears4 = TitelAppears[rnd.Next(0, TitelAppears.Length)];

            this.Title = $"Mastermind ({TitelAppears1},{TitelAppears2},{TitelAppears3},{TitelAppears4})";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CheckBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
