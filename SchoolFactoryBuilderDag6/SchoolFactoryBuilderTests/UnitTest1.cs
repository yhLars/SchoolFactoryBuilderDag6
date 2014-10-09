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
            string expected = "Jensen";
            EducationBuilder jensenBuilder = new JensenBuilder();

            JensenDirector jensenDirector = new JensenDirector();

            //Act

            IEducation acctual = jensenDirector.Build(jensenBuilder);
            

            //Assert
            Assert.AreEqual(expected,acctual.EducationName);
        }
    }
}
