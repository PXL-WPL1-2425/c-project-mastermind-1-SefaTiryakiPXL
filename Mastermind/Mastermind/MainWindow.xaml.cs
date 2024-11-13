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

        private void CheckBox1_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            // pakt wat de gelescteerde kleur is
            string kleur1 = CheckBox1.SelectedItem.ToString();
            if (kleur1 == null) return;
            switch (kleur1)
            {
                case "rood":
                    Kleur1.Background = Brushes.Red;
                break;

                case "geel":
                    Kleur1.Background = Brushes.Yellow;
                break;

                case "groen":
                    Kleur1.Background = Brushes.Green;
                break;

                case "oranje":
                    Kleur1.Background = Brushes.Orange;
                break;

                case "wit":
                    Kleur1.Background = Brushes.White;
                break;

                case "blauw":
                    Kleur1.Background = Brushes.Blue;
                break;
            }
        }
        private void CheckBox1_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            string kleur2 = CheckBox2.SelectedItem.ToString();

            if (kleur2 == null) return;
            switch (kleur2)
            {
                case "rood":
                    Kleur2.Background = Brushes.Red;
                break;

                case "geel":
                    Kleur2.Background = Brushes.Yellow;
                break;

                case "groen":
                    Kleur2.Background = Brushes.Green;
                break;

                case "oranje":
                    Kleur2.Background = Brushes.Orange;
                break;

                case "wit":
                    Kleur2.Background = Brushes.White;
                break;

                case "blauw":
                    Kleur2.Background = Brushes.Blue;
                break;
            }


        }
        private void CheckBox1_SelectionChanged3(object sender, SelectionChangedEventArgs e)
        {
            string kleur3 = CheckBox3.SelectedItem.ToString();

            if (kleur3 == null) return;
            switch (kleur3)
            {
                case "rood":
                    Kleur3.Background = Brushes.Red;
                break;

                case "geel":
                    Kleur3.Background = Brushes.Yellow;
                break;

                case "groen":
                    Kleur3.Background = Brushes.Green;
                break;

                case "oranje":
                    Kleur3.Background = Brushes.Orange;
                break;

                case "wit":
                    Kleur3.Background = Brushes.White;
                break;

                case "blauw":
                    Kleur3.Background = Brushes.Blue;
                break;
            }
        }

        private void CheckBox1_SelectionChanged4(object sender, SelectionChangedEventArgs e)
        {
            string kleur4 = CheckBox4.SelectedItem.ToString();
            if (kleur4 == null) return;
            switch (kleur4)
            {
                case "rood":
                    Kleur4.Background = Brushes.Red;
                break;

                case "geel":
                    Kleur4.Background = Brushes.Yellow;
                break;

                case "groen":
                    Kleur4.Background = Brushes.Green;
                break;

                case "oranje":
                    Kleur4.Background = Brushes.Orange;
                break;

                case "wit":
                    Kleur4.Background = Brushes.White;
                break;

                case "blauw":
                    Kleur4.Background = Brushes.Blue;
                break;
            }
        }
    }
}
