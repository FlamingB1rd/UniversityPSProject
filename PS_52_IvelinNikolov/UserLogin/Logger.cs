using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace UserLogin
{
    static class Logger
    {
        private static List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + "; "
            + LoginValidation.currentUserUsername + "; "
            + LoginValidation.currentUserRole + "; "
            + activity + "\n";
            currentSessionActivities.Add(activityLine);



            if (File.Exists("test.txt") == true)
            {
                File.AppendAllText("test.txt", activityLine);
            }
        }

        public static IEnumerable<string> printLogActivity()
        {
            StreamReader sr = new StreamReader("test.txt");
            List<string> fullLog = new List<string>();

            if (File.Exists("test.txt") == true)
                while (sr.EndOfStream == false)
                {
                    string line = sr.ReadLine();
                    fullLog.Add(line);
                }
            sr.Close();

            return fullLog;
            /*if (File.Exists("test.txt") == true)
            {
                String s = File.ReadAllText("test.txt");
                Console.WriteLine(s);
            }*/
        }
        public static IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            List<string> filteredSessionActivities = (from activity in currentSessionActivities where activity.Contains(filter) select activity).ToList();

            return filteredSessionActivities;
        }
    }
}
