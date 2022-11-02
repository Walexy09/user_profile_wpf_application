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

namespace user_profile_wpf_application
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

        private void addUsers_click(object sender, RoutedEventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(textBox.Text)) && (!listBox.Items.Contains(textBox.Text)))
            {

                listBox.Items.Add(textBox.Text);
                textBox.Clear();
                int itemsNo = listBox.Items.Count;
                string itemsCountMessage = itemsNo > 0 ? $"{itemsNo} items present" : "0 items present";
                itemsNoLbl.Content = itemsCountMessage;
            }
            else {

                MessageBox.Show("Sorry. Item already exists in the list, check and try again!!");
                return;
            }
        }

        private void moveBackward_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Move back by 1 count");
        }

        private void moveForward_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Move forward by 1 count");
        }
    }
}
