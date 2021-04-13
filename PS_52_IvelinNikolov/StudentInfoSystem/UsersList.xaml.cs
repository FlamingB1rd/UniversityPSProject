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
using UserLogin;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for UsersList.xaml
    /// </summary>
    public partial class UsersList : Window
    {
        public UsersList()
        {
            InitializeComponent();

            foreach (User user in UserData.testUser)
            {
                ListBoxItem i = new ListBoxItem();
                i.Content = user.username + " " + user.fakNum;
                userListBox.Items.Add(i);
            }
        }
    }
}
