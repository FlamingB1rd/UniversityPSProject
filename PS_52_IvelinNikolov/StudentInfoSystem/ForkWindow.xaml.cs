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

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for ForkWindow.xaml
    /// </summary>
    public partial class ForkWindow : Window
    {
        public ForkWindow()
        {
            InitializeComponent();
        }

        private void btnShowStudents_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            StudentsList studentsListWindow = new StudentsList();
            studentsListWindow.Height = mainWindow.Height;
            studentsListWindow.Width = mainWindow.Width;
            studentsListWindow.ShowDialog();
            this.Close();
        }

        private void btnShowUsers_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            UsersList usersListWindow = new UsersList();
            usersListWindow.Height = mainWindow.Height;
            usersListWindow.Width = mainWindow.Width;
            usersListWindow.ShowDialog();
            this.Close();
        }
    }
}
