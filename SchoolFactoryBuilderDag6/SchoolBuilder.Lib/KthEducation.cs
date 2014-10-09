using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class KthEducation:AbstractEducation
    {
        public KthEducation( string assignTeacher, string inviteStudents, string processStudentFeedback) 
            : base("KTH", assignTeacher, inviteStudents, processStudentFeedback)
        {
        }
    }
}
