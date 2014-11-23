using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInfoSystem.Data
{
    class UserData
    {
        public static User IsUserPassCorrect(string username, string password)
        {
            return UserData._IsUserPassCorrect(username, password);
        }
        private static User _IsUserPassCorrect(string username, string password)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Username == username) &&
                               (users.Password == password)
                               select users).ToArray<User>();
            if (queryResult.Count<User>() > 0)
                return queryResult.ElementAt<User>(0);
            return null;
        }

        public static Student getStudentByFacNumber(String number) 
        {
            StudentDataContext dc = new StudentDataContext();
            var quertyResult = (from student in dc.GetTable<Student>()
                                where (student.FakNumber == number)
                                select student).ToArray<Student>();

            if (quertyResult[0] != null)
            {
                return quertyResult[0];
            }
            else 
            {
                return null;
            }
                
                
        }
    }
}
