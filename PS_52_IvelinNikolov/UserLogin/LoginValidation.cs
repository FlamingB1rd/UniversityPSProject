using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    class LoginValidation
    {
        public static UserRoles currentUserRole
        { private set; get; }
        public static String currentUserUsername
        { private set; get;} 
        private String username;
        private String password;
        private String errorMessage;
        public delegate void ActionOnError(string errorMsg);
        private ActionOnError actionOnError;

        public LoginValidation(String username, String password, ActionOnError actionOnError)
        {
            this.username = username;
            this.password = password;
            this.actionOnError = actionOnError;
        }

        public bool ValidateUserInput(ref User user)
        {

            if (username.Equals(String.Empty) == true)
            {
                errorMessage = "No username was given!";
                actionOnError(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            if (password.Equals(String.Empty) == true)
            {
                errorMessage = "No password was given!";
                actionOnError(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            if (username.Length < 5 == true || password.Length < 5)
            {
                errorMessage = "Username and Password must be above 5 symbols!";
                actionOnError(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }
            
            user = UserData.IsUserPassCorrect(username, password);

            if (user == null)
            {
                errorMessage = "Username or Password doesn't match!";
                actionOnError(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            currentUserRole = (UserRoles)user.role;
            currentUserUsername = user.username;
            Logger.LogActivity("Successful Login!");
            return true;

            /*            switch (user.role)
                        {
                            case 0:
                                currentUserRole = UserRoles.ANONYMOUS;
                                break;
                            case 1:
                                currentUserRole = UserRoles.ADMIN;
                                break;
                            case 2:
                                currentUserRole = UserRoles.INSPECTOR;
                                break;
                            case 3:
                                currentUserRole = UserRoles.PROFESSOR;
                                break;
                            case 4:
                                currentUserRole = UserRoles.STUDENT;
                                break;
                            default:
                                currentUserRole = UserRoles.ADMIN;
                                break;
                        }  */
        }
    }
}
