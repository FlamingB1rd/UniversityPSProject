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

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Window
    {
        public ExpenseItHome()
        {
            InitializeComponent();
            ListBoxItem lisa = new ListBoxItem();
            lisa.Content = "Lisa";
            peopleListBox.Items.Add(lisa);

            ListBoxItem john = new ListBoxItem();
            john.Content = "John";
            peopleListBox.Items.Add(john);

            ListBoxItem mary = new ListBoxItem();
            mary.Content = "Mary";
            peopleListBox.Items.Add(mary);

            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);

            ListBoxItem david = new ListBoxItem();
            david.Content = "David";
            peopleListBox.Items.Add(david);

        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReport expenseReportWindow = new ExpenseReport();
            expenseReportWindow.Height = this.Height;
            expenseReportWindow.Width = this.Width;
            expenseReportWindow.ShowDialog();
        }
    }
}
