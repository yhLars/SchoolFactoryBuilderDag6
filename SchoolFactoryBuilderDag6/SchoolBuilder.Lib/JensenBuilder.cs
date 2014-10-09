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
            jensenEducationInProgress.TeacherName = teacher;
        }

        public override void InviteStudents(string student)
        {
            jensenEducationInProgress.Student = student;
        }

        public override void ProcessStudentFeedback(string feedback)
        {
            jensenEducationInProgress.Feedback = feedback;
        }

        public override IEducation Education
        {
            get { return jensenEducationInProgress; }
        }
    } 
}
