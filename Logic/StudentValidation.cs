using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class StudentValidation
    {
        public static Student IsThereStudent(User usr)
        {
            return UserData.getStudentByFacNumber(usr.FacNumber);
        }
    }
}
