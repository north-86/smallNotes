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

namespace smallNotes
{
    public partial class Preferences : Window
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void LightRB_Checked(object sender, RoutedEventArgs e)
        {
            this.Owner.Background = new SolidColorBrush(Colors.White);
            this.Background = new SolidColorBrush(Colors.White);
        }

        private void DarkRB_Checked(object sender, RoutedEventArgs e)
        {
            this.Owner.Background = new SolidColorBrush(Colors.Gray);
            this.Background = new SolidColorBrush(Colors.Gray);
        }
    }
}
