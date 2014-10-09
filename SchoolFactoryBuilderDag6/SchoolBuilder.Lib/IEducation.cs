using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public interface IEducation
    {
        string EducationName { get; }
        string AssignTeacher { get; set; }
        string InviteStudents { get; set; }
        string ProcessStudentFeedback { get; set; }
    }
}
