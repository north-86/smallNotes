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

namespace smallNotes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNotes_Click(object sender, RoutedEventArgs e)
        {
            StackPanel stack = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(5, 5, 0, 0) };
            CheckBox checkBox = new CheckBox() { Height = 20, Width = 20, IsChecked = false };
            TextBox textBox = new TextBox() { Width = 380, MinHeight = 20, TextWrapping = TextWrapping.Wrap, VerticalContentAlignment = VerticalAlignment.Center, FontSize = 13, FontFamily = new FontFamily("Courier New") };
            Expander expander = new Expander();
            
            StackPanel stackExp = new StackPanel() { Orientation = Orientation.Vertical };

            RadioButton rb1 = new RadioButton() { Background = new SolidColorBrush(Colors.Yellow) };
            rb1.Checked += RBYellow_Checked;
            void RBYellow_Checked(object sender, RoutedEventArgs e)
            {
                RadioButton pressed = (RadioButton)sender;
                textBox.Background = new SolidColorBrush(Colors.Yellow);
            }

            RadioButton rb2 = new RadioButton() { Background = new SolidColorBrush(Colors.Orange) };
            rb2.Checked += RBOrange_Checked;
            void RBOrange_Checked(object sender, RoutedEventArgs e)
            {
                RadioButton pressed = (RadioButton)sender;
                textBox.Background = new SolidColorBrush(Colors.Orange);
            }

            RadioButton rb3 = new RadioButton() { Background = new SolidColorBrush(Colors.Red) };
            rb3.Checked += RBRed_Checked;
            void RBRed_Checked(object sender, RoutedEventArgs e)
            {
                RadioButton pressed = (RadioButton)sender;
                textBox.Background = new SolidColorBrush(Colors.Red);
            }

            stackExp.Children.Add(rb1);
            stackExp.Children.Add(rb2);
            stackExp.Children.Add(rb3);
            expander.Content = stackExp;

            stack.Children.Add(checkBox);
            stack.Children.Add(textBox);
            stack.Children.Add(expander);

            stackPanel.Children.Add(stack);
        }

        private void Preferences_Click(object sender, RoutedEventArgs e)
        {
            Preferences pref = new Preferences();
            pref.Owner = this;
            pref.ShowDialog();
        }
    }
}
