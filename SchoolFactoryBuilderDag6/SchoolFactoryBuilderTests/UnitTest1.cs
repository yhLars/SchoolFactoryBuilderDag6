using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolBuilder.Lib;

namespace SchoolFactoryBuilderTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Jensen_Education()
        {
            //Arrange
            //JensenEducation expected= new JensenEducation();
            //expected.EducationName = "Jensen";
            string expectedEducationName = "Jensen";
            string expectedTeacher = "Ellie";
            string expectedStudents = "Samir";
            string expectedFeedBack = "Perfekt";

            AbstractEducation education = new JensenEducation("Ellie", "Samir", "Perfekt");
            EducationBuilder builder = new JensenBuilder(education);
            EducationDirector director = new JensenDirector();

            //Act

            IEducation actual = director.Build(builder);
            

            //Assert
            Assert.AreEqual(expectedEducationName, actual.EducationName);
            Assert.AreEqual(expectedTeacher, actual.AssignTeacher);
            Assert.AreEqual(expectedStudents, actual.InviteStudents);
            Assert.AreEqual(expectedFeedBack, actual.ProcessStudentFeedback);
        }
    }
}
