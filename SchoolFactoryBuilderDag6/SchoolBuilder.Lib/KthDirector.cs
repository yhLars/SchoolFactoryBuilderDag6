using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class KthDirector:EducationDirector
    {
        public override IEducation Build(EducationBuilder builder)
        {
            builder.AssignTeacher(builder.Education.TeacherName);

            return builder.Education;
        }
    }
}
