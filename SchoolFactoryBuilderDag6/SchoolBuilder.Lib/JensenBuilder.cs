using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class JensenBuilder:EducationBuilder
    {
        private AbstractEducation jensenEducationInProgress;

        public JensenBuilder(AbstractEducation education)
        {
            jensenEducationInProgress = education;
        }

        public override void AssignTeacher(string teacher)
        {
            jensenEducationInProgress.AssignTeacher = teacher;
        }

        public override void InviteStudents(string student)
        {
            jensenEducationInProgress.InviteStudents = student;
        }

        public override void ProcessStudentFeedback(string feedback)
        {
            jensenEducationInProgress.ProcessStudentFeedback = feedback;
        }

        public override IEducation Education
        {
            get { return jensenEducationInProgress; }
        }
    } 
}
