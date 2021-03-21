using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace UserLogin
{
    static class UserData
    {
        private static List<User> _testUser;
        public static List<User> testUser
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }

        public static User IsUserPassCorrect(String username, String password)
        {
            User foundUser = (from user in testUser where user.username.Equals(username) && user.password.Equals(password) select user).FirstOrDefault<User>(); // само с First() хвърля ексептион при несъвпадаща парола
            /*foreach (User user in testUser)
            {
                if (user.username.Equals(username) && user.password.Equals(password))
                {
                    return user;
                }
            }*/
            return foundUser;
        }

        private static User findUserByUsername(String username)
        {
            foreach (User user in testUser)
            {
                if (user.username.Equals(username))
                {
                    return user;
                }
            }
            return null;
        }

        static private void ResetTestUserData() 
        {
            if(_testUser == null)
            {
                _testUser = new List<User>(3);

                _testUser.Add(new User()
                {
                    username = "Flamey",
                    password = "12345",
                    fakNum = "121218091",
                    role = 1, //Admin
                    created = DateTime.Today,
                    validThrough = DateTime.MaxValue
                });

                _testUser.Add(new User()
                {
                    username = "Gongo",
                    password = "54321",
                    fakNum = "121218999",
                    role = 4, //Student
                    created = DateTime.Today,
                    validThrough = DateTime.MaxValue
                });

                _testUser.Add(new User()
                {
                    username = "Happy",
                    password = "00000",
                    fakNum = "121218000",
                    role = 4, //Student
                    created = DateTime.Today,
                    validThrough = DateTime.MaxValue
                });

                //За custom set up за немасивен test User:
                /*Console.WriteLine("testUser username: ");
                _testUser.username = Console.ReadLine();
                Console.WriteLine("testUser password: ");
                _testUser.password = Console.ReadLine();
                Console.WriteLine("testUser facaulty number: ");
                _testUser.fakNum = Console.ReadLine();
                Console.WriteLine("testUser role: ");
                _testUser.role = int.Parse(Console.ReadLine());*/
            }

        }

        public static void SetUserActiveTo(String username, DateTime newValidThroughDate)
        {
            User user = findUserByUsername(username);

            user.validThrough = newValidThroughDate;
            Logger.LogActivity("Activity expiration date of " + username + " changed successfully!");
        }

        public static void AssignUserRole(String username, int newUserRole)
        {
            User user = findUserByUsername(username);

            user.role = newUserRole;
            Logger.LogActivity("Role of " + username + " changed successfully!");
        }
    }
}
