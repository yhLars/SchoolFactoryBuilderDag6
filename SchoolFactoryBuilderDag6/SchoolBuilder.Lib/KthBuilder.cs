using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class KthBuilder:EducationBuilder
    {
        private AbstractEducation _educationInProgress;

        public KthBuilder(AbstractEducation education)
        {
            _educationInProgress = education;
        }
        public override void AssignTeacher(string teacher)
        {
            _educationInProgress.TeacherName = teacher;
        }

        public override void InviteStudents(string student)
        {
            _educationInProgress.Student = student;
        }

        public override IEducation Education
        {
            get { return _educationInProgress; }
        }
    }
}
