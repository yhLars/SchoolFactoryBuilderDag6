using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public abstract class AbstractEducation : IEducation
    {
        private string _educationName;
        private string _assignTeacher;
        private string _inviteStudents;
        private string _processStudentFeedback;

        public AbstractEducation(string educationName, string assignTeacher, string inviteStudents, string processStudentFeedback)
        {
            _educationName = educationName;
            _assignTeacher = assignTeacher;
            _inviteStudents = inviteStudents;
            _processStudentFeedback = processStudentFeedback;
        }

        public string EducationName
        {
            get { return _educationName; }
        }

        public string AssignTeacher
        {
            get { return _assignTeacher; }
            set { _assignTeacher = value; }
        }

        public string InviteStudents
        {
            get { return _inviteStudents; }
            set { _inviteStudents = value; }
        }

        public string ProcessStudentFeedback
        {
            get { return _processStudentFeedback; }
            set { _processStudentFeedback = value; }
        }
    }
}
