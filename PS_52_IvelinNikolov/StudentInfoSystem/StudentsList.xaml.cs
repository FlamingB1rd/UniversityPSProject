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
    /// Interaction logic for StudentsList.xaml
    /// </summary>
    public partial class StudentsList : Window
    {
        public StudentsList()
        {
            InitializeComponent();

            foreach (Student student in StudentData.testStudent)
            {
                ListBoxItem i = new ListBoxItem();
                i.Content = student.firstName + " " + student.lastName;
                StudentListBox.Items.Add(i);
            }
        }
    }
}
