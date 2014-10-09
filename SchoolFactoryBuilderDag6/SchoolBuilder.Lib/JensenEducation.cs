using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class JensenEducation :IEducation
    {
         public string EducationName { get; set; }

        public JensenEducation()
        {
            EducationName = "Jensen";
        }
    }
}
