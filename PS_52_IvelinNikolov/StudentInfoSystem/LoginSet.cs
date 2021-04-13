using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace StudentInfoSystem
{
    public class LoginSet : INotifyPropertyChanged
    {
        string _username = "";
        string _password = "";
        LoginCommand _loginCommand = new LoginCommand();
        public LoginCommand LoginCommand
        {
            get { return _loginCommand; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public LoginSet()
        {

        }
        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged("Username");
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set

            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}
