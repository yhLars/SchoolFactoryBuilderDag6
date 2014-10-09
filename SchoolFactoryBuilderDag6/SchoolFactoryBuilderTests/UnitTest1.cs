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
            Assert.AreEqual(expectedTeacher, actual.TeacherName);
            Assert.AreEqual(expectedStudents, actual.Student);
            Assert.AreEqual(expectedFeedBack, actual.Feedback);
        }

        [TestMethod]
        public void Test_Nackademin_Education()
        {
            //Arrange
            string expectedEducationName = "Nackademin";
            string expectedTeacher = "Ellie";
            string expectedStudents = "Samir";
            string expectedFeedBack = "SiSåDär";
            
            AbstractEducation education = new NackademinEducation("Ellie","Samir","SiSåDär");
            EducationBuilder builder = new NackademinBuilder(education);
            NackademinDirector director = new NackademinDirector();
            
            //Act
            IEducation actual = director.Build(builder);

            //Assert
            Assert.AreEqual(expectedEducationName,actual.EducationName);
            Assert.AreEqual(expectedTeacher, actual.TeacherName);
            Assert.AreEqual(expectedStudents, actual.Student);
            Assert.AreEqual(expectedFeedBack, actual.Feedback);
        }

        [TestMethod]
        public void Test_Kth_Education()
        {
            //Arrange
            string expectedEducationName = "KTH";
            string expectedTeacher = "Ellie";
            string expectedStudents = "Samir";
            string expectedFeedBack = "Perfect";

            AbstractEducation education = new KthEducation("Ellie","Samir","Perfect");
            EducationBuilder builder = new KthBuilder(education);
            EducationDirector director = new KthDirector();
            //Act
            IEducation actual = director.Build(builder);
            //Assert

            Assert.AreEqual(expectedEducationName,actual.EducationName);
        }
    }
}
