using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Vocabulary Vocabulary1;
        public Window1(Vocabulary vocabulary)
        {
            Vocabulary1 = vocabulary;
            InitializeComponent();
        }

        private void Start_click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
