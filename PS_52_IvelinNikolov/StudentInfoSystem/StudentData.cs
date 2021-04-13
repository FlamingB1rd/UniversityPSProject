using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoSystem
{
    class StudentData
    {
        private static List<Student> _testStudent;
        public static List<Student> testStudent
        {
            get
            {
                ResetTestStudentData();
                return _testStudent;
            }
            set { }
        }

        static private void ResetTestStudentData()
        {
            if (_testStudent == null)
            {
                _testStudent = new List<Student>(2);

                _testStudent.Add(new Student()
                {
                    firstName = "Ivelin",
                    surName = "Dimitrov",
                    lastName = "Nikolov",
                    facaulty = "FKST",
                    major = "KSI",
                    qualificationDegree = "Бакалавър",
                    status = "заверил",
                    facaultyNumber = "121218091",
                    course = "3",
                    _class = "9",
                    group = "52"
                 });

                _testStudent.Add(new Student()
                {
                    firstName = "Gongo",
                    surName = "Kristofer",
                    lastName = "Andreaz",
                    facaulty = "FKST",
                    major = "KSI",
                    qualificationDegree = "Бакалавър",
                    status = "заверил",
                    facaultyNumber = "121218999",
                    course = "3",
                    _class = "9",
                    group = "52"
                });

                _testStudent.Add(new Student()
                {
                    firstName = "Happy",
                    surName = "Blue",
                    lastName = "Flighty",
                    facaulty = "FKST",
                    major = "KSI",
                    qualificationDegree = "Бакалавър",
                    status = "заверил",
                    facaultyNumber = "121218000",
                    course = "3",
                    _class = "9",
                    group = "52"
                });
            }
        }
    }
}
