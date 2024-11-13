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

            CheckBox1.Items.Add("rood");
            CheckBox1.Items.Add("geel");
            CheckBox1.Items.Add("groen");
            CheckBox1.Items.Add("oranje");
            CheckBox1.Items.Add("wit");
            CheckBox1.Items.Add("blauw");

            CheckBox2.Items.Add("rood");
            CheckBox2.Items.Add("geel");
            CheckBox2.Items.Add("groen");
            CheckBox2.Items.Add("oranje");
            CheckBox2.Items.Add("wit");
            CheckBox2.Items.Add("blauw");

            CheckBox3.Items.Add("rood");
            CheckBox3.Items.Add("geel");
            CheckBox3.Items.Add("groen");
            CheckBox3.Items.Add("oranje");
            CheckBox3.Items.Add("wit");
            CheckBox3.Items.Add("blauw");

            CheckBox4.Items.Add("rood");
            CheckBox4.Items.Add("geel");
            CheckBox4.Items.Add("groen");
            CheckBox4.Items.Add("oranje");
            CheckBox4.Items.Add("wit");
            CheckBox4.Items.Add("blauw");

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
