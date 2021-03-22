using System;
using System.Collections.Generic;
using System.IO;
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
using UserLogin;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Student checkStudent
        { get; set; }
        public MainWindow()
        {

            /*
             * Test case - User - username Flamey Password: 12345 Fac nomer 121218091 - syotvetstva na Ivelin Nikolov.
             */
            StreamReader sr = new StreamReader("test.txt");

            InitializeComponent();
            checkStudent = StudentData.testStudent[0];
            if (checkStudent != null)
            {
                enableInfoFields();
                fillOutInformation();
                User user = StudentValidation.GetUserDataByStudent(checkStudent);
                if(user != null)
                {
                    string lastLogin = "";
                    if (File.Exists("test.txt") == true)
                        while (sr.EndOfStream == false)
                        {
                            string line = sr.ReadLine();
                            if (line.Contains(user.username) && line.Contains("Successful Login!"))
                            {
                                lastLogin = line.Substring(0, 20);
                            }
                        }
                    sr.Close();
                    txtLastLogin.Text = lastLogin;
                }
            }
            else
            {
                disableInfoFields();
            }
        }

        void fillOutInformation()
        {
            Student student = StudentData.testStudent[0];

            txtName.Text = student.firstName;
            txtMiddleName.Text = student.surName;
            txtLastName.Text = student.lastName;
            txtFacaulty.Text = student.facaulty;
            txtMajor.Text = student.major;
            txtQualificationDegree.Text = student.qualificationDegree;
            txtStatus.Text = student.status;
            txtFacaultyNumber.Text = student.facaultyNumber;
            txtCourse.Text = student.course;
            txtClass.Text = student._class;
            txtGroup.Text = student.group;
        }

        void resetInformation()
        {
            txtName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtFacaulty.Text = "";
            txtMajor.Text = "";
            txtQualificationDegree.Text = "";
            txtStatus.Text = "";
            txtFacaultyNumber.Text = "";
            txtCourse.Text = "";
            txtClass.Text = "";
            txtGroup.Text = "";
        }

        void disableInfoFields()
        {
            txtName.IsEnabled = false;
            txtMiddleName.IsEnabled = false;
            txtLastName.IsEnabled = false;
            txtFacaulty.IsEnabled = false;
            txtMajor.IsEnabled = false;
            txtQualificationDegree.IsEnabled = false;
            txtStatus.IsEnabled = false;
            txtFacaultyNumber.IsEnabled = false;
            txtCourse.IsEnabled = false;
            txtClass.IsEnabled = false;
            txtGroup.IsEnabled = false;
        }

        void enableInfoFields()
        {
            txtName.IsEnabled = true;
            txtMiddleName.IsEnabled = true;
            txtLastName.IsEnabled = true;
            txtFacaulty.IsEnabled = true;
            txtMajor.IsEnabled = true;
            txtQualificationDegree.IsEnabled = true;
            txtStatus.IsEnabled = true;
            txtFacaultyNumber.IsEnabled = true;
            txtCourse.IsEnabled = true;
            txtClass.IsEnabled = true;
            txtGroup.IsEnabled = true;
        }
    }

}
