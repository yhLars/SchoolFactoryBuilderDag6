using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class NackademinEducation:IEducation
    {
        public string EducationName { get; set; }

        public NackademinEducation()
        {
            EducationName = "Nackademin";
        }
        
    }
}
