using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using UserLogin;

namespace StudentInfoSystem
{
    public class LoginCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var loginSet = parameter as LoginSet;

            LoginValidation loginValidation = new LoginValidation(loginSet.Username, loginSet.Password, new LoginValidation.ActionOnError(PrintErrorMessage));
            User validUser = null;
            if (loginValidation.ValidateUserInput(ref validUser))
            {
                if (validUser.role == 1)
                {
                    //Message for admin
                    MessageBox.Show("Welcome administrator!", "Notice!", MessageBoxButton.OK);

                    MainWindow mainWindow = new MainWindow(validUser);
                    mainWindow.Show();
                    return;
                }
                else
                {
                    MainWindow mainWindow = new MainWindow(validUser);
                    mainWindow.Show();
                    return;
                }
            }

            MessageBox.Show("Wrong username or password!", "Notice!", MessageBoxButton.OK);

            loginSet.Username = loginSet.Password = "";
        }

        public static void PrintErrorMessage(string errorMessage)
        {
            Console.WriteLine("!!! " + errorMessage + " !!!");
        }
    }
}
