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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vocabulary vocabulary;
        public MainWindow()
        {
            InitializeComponent();
            vocabulary = new Vocabulary();
            var window = new Window1(vocabulary);
            window.StartButton.Click += ButtonNextWord_Click;
            window.ShowDialog();
            
        }

        void ChangeBackgroundOfWord2(string answer)
        {
            if (vocabulary.CheckIfAnswerIsCorrect(answer))
            {
                Word2.Background = Brushes.YellowGreen;
            }
            else
            {
                Word2.Background = Brushes.IndianRed;
            }
        }

        void PrepareAllSpacesForNextRound()
        {
            Answer.Clear();
            Word2.Items.Clear();
            Word1.Items.Clear();
            Word2.Background = Brushes.White;
        }

        private void ButtonNextWord_Click(object sender, RoutedEventArgs e)
        {
            PrepareAllSpacesForNextRound();
            string wordInPolish = vocabulary.FindNextPairOfWords().Key;
            Word1.Items.Add(wordInPolish);
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                string answer = Answer.Text;
                if (!string.IsNullOrWhiteSpace(answer))
                {
                    Word2.Items.Clear();
                    string wordInItalian = vocabulary.FindRightAnswer();
                    Word2.Items.Add(wordInItalian);
                    ChangeBackgroundOfWord2(answer);
                }
            }
        }
    }
}
