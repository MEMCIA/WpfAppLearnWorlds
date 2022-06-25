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
        Dictionary<string, string> words = new Dictionary<string, string> { { "uroczy", "carino" },{"kot", "gatto" }, { "dobranoc", "buonanotte"} };
        int numberOfWord = 0;
        public MainWindow()
        {
            InitializeComponent();

            var window = new Window1();
            window.ShowDialog();

        }

        private void ButtonAddAnswer_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Answer.Text))
            {
                //WordInItalian = words.Values
            }
        }
    }
}
