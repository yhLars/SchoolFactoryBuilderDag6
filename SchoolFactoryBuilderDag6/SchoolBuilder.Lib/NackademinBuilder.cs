using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class NackademinBuilder: EducationBuilder
    {
        private AbstractEducation _educationInPogress;

        public NackademinBuilder(AbstractEducation education)
        {
            _educationInPogress = education;
        }

        public override IEducation Education
        {
            get { return _educationInPogress; }
        }

        public override void AssignTeacher(string teacher)
        {
            _educationInPogress.TeacherName = teacher;
        }

        public override void InviteStudents(string student)
        {
            _educationInPogress.Student = student;
        }

        public override void ProcessStudentFeedback(string feedback)
        {
            _educationInPogress.Feedback = feedback;
        }
    }
}
