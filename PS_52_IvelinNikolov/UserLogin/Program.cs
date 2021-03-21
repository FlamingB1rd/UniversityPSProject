using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a username and password:");
            LoginValidation loginValidation = new LoginValidation(Console.ReadLine(), Console.ReadLine(), new LoginValidation.ActionOnError(PrintErrorMessage));

            User user = null;

            //UserData.AssignUserRole("Flamey", 4); -- Testing role changing function

            if (loginValidation.ValidateUserInput(ref user))
            {
                if(user.role == 1)
                {
                    Console.WriteLine("Welcome administrator!");
                    int choice;
                    bool running = true;
                    StringBuilder sb = new StringBuilder();

                    while (running)
                    {
                        AdministratorMenu();
                        choice = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        String tempUserName;
                        int tempRole;
                        DateTime tempDateOfActivation;

                        switch (choice)
                        {
                            case 0:
                                running = false;
                                Console.WriteLine("\nExiting...");
                                break;
                            case 1:
                                Console.WriteLine("\nChoose the username of the person whose's role you'll change: ");
                                tempUserName = Console.ReadLine();
                                Console.WriteLine("Choose the new role: ");
                                tempRole = int.Parse(Console.ReadLine());
                                UserData.AssignUserRole(tempUserName, tempRole);
                                break;
                            case 2:
                                Console.WriteLine("\nChoose the username of the person whose's active date you'll change: ");
                                tempUserName = Console.ReadLine();
                                Console.WriteLine("Choose a new date of expiration: ");
                                tempDateOfActivation = DateTime.Parse(Console.ReadLine());
                                UserData.SetUserActiveTo(tempUserName, tempDateOfActivation);
                                break;
                            case 3:
                                printAllUsers();
                                break;
                            case 4:
                                IEnumerable<string> fullLog = Logger.printLogActivity();
                                sb.Append("Full session list of activities: \n");

                                foreach (string s in fullLog)
                                {
                                    sb.Append(s + "\n");
                                }
                                Console.WriteLine(sb.ToString());
                                sb.Clear();
                                break;
                            case 5:
                                Console.WriteLine("\nPlease enter a filter for the session: ");
                                string filter = Console.ReadLine();
                                IEnumerable<string> currentActs = Logger.GetCurrentSessionActivities(filter);
                                sb.Append("Current session list of activities: \n");

                                foreach (string s in currentActs)
                                {
                                    sb.Append(s);
                                }
                                Console.WriteLine(sb.ToString());
                                sb.Clear();
                                break;
                            default:
                                break;
                        }
                    }
                }

                Console.WriteLine("username = {0}; password = {1}; fakNum = {2}; Role = {3}; Created on = {4}; Valid Through = {5}",
                user.username, user.password, user.fakNum, user.role, user.created, user.validThrough);
            }

            switch (LoginValidation.currentUserRole)
            {
                case UserRoles.ANONYMOUS:
                    Console.WriteLine("User role: ANONYMOUS");
                    break;
                case UserRoles.ADMIN:
                    Console.WriteLine("User role: ADMIN");
                    break;
                case UserRoles.INSPECTOR:
                    Console.WriteLine("User role: INSPECTOR");
                    break;
                case UserRoles.PROFESSOR:
                    Console.WriteLine("User role: PROFESSOR");
                    break;
                case UserRoles.STUDENT:
                    Console.WriteLine("User role: STUDENT");
                    break;
                default:
                    Console.WriteLine("User role: Anonymous");
                    break;
            }
        }

        public static void PrintErrorMessage(string errorMessage)
        {
            Console.WriteLine("!!! " + errorMessage + " !!!");
        }

        private static void AdministratorMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Choose option: ");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Change a user's role");
            Console.WriteLine("2: Change a user's activity expiration date");
            Console.WriteLine("3: List all users");
            Console.WriteLine("4: Print log activity");
            Console.WriteLine("5: Print current session activity");
            Console.Write("Choice: ");
        }

        private static void printAllUsers()
        {
            foreach (User user in UserData.testUser)
            {
                Console.WriteLine("username = {0}; password = {1}; fakNum = {2}; Role = {3}; Created on = {4}; Valid Through = {5}",
                user.username, user.password, user.fakNum, user.role, user.created, user.validThrough);
            }
        }
    }
}
