using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class JensenEducation : AbstractEducation
    {
        public JensenEducation(string assignTeacher, string inviteStudents, string processStudentFeedback)
            : base("Jensen", assignTeacher, inviteStudents, processStudentFeedback)
        {
        }
    }
}
