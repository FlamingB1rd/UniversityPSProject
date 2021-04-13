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

namespace WPFHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);

            ListBoxItem david = new ListBoxItem();
            david.Content = "David";
            peopleListBox.Items.Add(david);

            peopleListBox.SelectedItem = james;
        }


        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    s = s + ((TextBox)item).Text;
                    s = s + '\n';
                }
            }

            if (txtName.Text.Length <= 2)
            {
                MessageBox.Show("Името е невалидно. Моля въведете ново име!");
            }
            else
            {
                MessageBox.Show("Здрасти " + s + "!!! \nТова е моята първа програма на Visual Studio 2019!");
            }

            //to do: проверка дали са числа да не гръмне компилатора при подаване на string 
            int n = int.Parse(txtNFactoriel.Text);
            int y = int.Parse(txtY.Text);
            MessageBox.Show("N факториел е: " + factoriel(n) + "\n" + "N на степен Y e: " + powerOf(n, y));

        }
        private double powerOf(int x, int y)
        {
            double result;
            result = Math.Pow(x, y);
            return result;
        }
        private int factoriel(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            return fact;
        }

        private void MainWindow_OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Сигурни ли сте, че искате да затворите приложението?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();

            textBlock1.Text = DateTime.Now.ToString();
        }

        private void btnGreeting_Click(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi " + greetingMsg);
        }
    }
}
