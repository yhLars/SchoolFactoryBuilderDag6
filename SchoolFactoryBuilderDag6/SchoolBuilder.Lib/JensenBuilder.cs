using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class JensenBuilder:EducationBuilder
    {
        public override IEducation Education
        {
            get { return new JensenEducation(); }
        }

        public override void AssignTeacher(){}
        public override void InviteStudents() { }
        public override void ProcessStudentFeedback() { }
    } 
   
}
