using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class NackademinEducation:AbstractEducation
    {
        public NackademinEducation( string assignTeacher, string inviteStudents, string processStudentFeedback) 
            : base("Nackademin", assignTeacher, inviteStudents, processStudentFeedback)
        {
        }
    }
}
