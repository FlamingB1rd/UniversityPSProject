using System;
using System.Collections.Generic;
using System.Text;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentValidation
    {
        public static Student GetStudentDataByUser(User user)
        {
            foreach (Student student in StudentData.testStudent)
            {
                if (!(user.fakNum.Equals(String.Empty)) && student.facaultyNumber.Equals(user.fakNum))
                {
                    return student;
                }
            }
            Console.WriteLine("No student found with this facaulty number!");
            return null;
        }

        public static User GetUserDataByStudent(Student student)
        {
            foreach (User user in UserData.testUser)
            {
                if(student.facaultyNumber.Equals(user.fakNum))
                {
                    return user;
                }
            }
            Console.WriteLine("No user found with this facaulty number!");
            return null;
        }
    }
}
