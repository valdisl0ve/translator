using System;
using System.Collections.Generic;
using System.IO;
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

namespace translater
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

        public static Dictionary<string, string> wordsUA = new Dictionary<string, string>();
        public static Dictionary<string, string> wordsPL = new Dictionary<string, string>();
        public static Dictionary<string, string> wordsEN = new Dictionary<string, string>();

        private void Butt_translate_Click(object sender, RoutedEventArgs e)
        {

            Label_result.Content = " ";

            if (CheckBox_Ukrain.IsChecked == true)
            {
                UkrainCheck();

                string value;

                if (wordsUA.TryGetValue(TextBox_translate.Text, out value))
                {
                    Label_result.Content = value;
                }


            }  if (CheckBox_English.IsChecked == true)
            {
                EnglishCheck();

                string value;

                if (wordsEN.TryGetValue(TextBox_translate.Text, out value))
                {
                    Label_result.Content = value;
                }
            }
            if (CheckBox_Poland.IsChecked == true)
            {
                PolandCheck();

                string value;

                if (wordsPL.TryGetValue(TextBox_translate.Text, out value))
                {
                    Label_result.Content = value;
                }
            }
        }

        public static void Check ()
        {
           
        }


        public static void UkrainCheck()
        {

            StreamReader sr = new StreamReader(@"C:\IDS\C#\C# tranclater\translater\translater\Ukrain.txt");
            string line;


            while ((line = sr.ReadLine()) != null)
            {
                wordsUA.Clear();
                string[] word = line.Split('-');
                wordsUA.Add(word[0], word[1]);

            }
           
        }


        public static void EnglishCheck()
        {

            StreamReader sr = new StreamReader(@"C:\IDS\C#\C# tranclater\translater\translater\English.txt");
            string line;


            while ((line = sr.ReadLine()) != null)
            {
                wordsEN.Clear();
                string[] word = line.Split('-');
                wordsEN.Add(word[0], word[1]);

            }

        }


        public static void PolandCheck()
        {

            StreamReader sr = new StreamReader(@"C:\IDS\C#\C# tranclater\translater\translater\Poland.txt");
            string line;


            while ((line = sr.ReadLine()) != null)
            {
                wordsPL.Clear();
                string[] word = line.Split('-');
                wordsPL.Add(word[0], word[1]);

            }

        }

    }
}
