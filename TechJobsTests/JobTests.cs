using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job test_job;
        [TestInitialize]
        public void CreateJobObject()
        {
            test_job = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));      
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job1 = new Job();
            Job test_job2 = new Job();
            
            Assert.AreEqual(test_job1.Id, test_job2.Id - 1);

            
        }

        [TestMethod]
        public void TestJobConstructorSetAllFields()
        {
            Assert.IsTrue(test_job.Name == "Product Tester");
            Assert.IsTrue(test_job.EmployerName.Value == "ACME");
            Assert.IsTrue(test_job.EmployerLocation.Value == "Desert");
            Assert.IsTrue(test_job.JobType.Value == "Quality Control");
            Assert.IsTrue(test_job.JobCoreCompetency.ToString() == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
           Job testing = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
           Job testing1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(testing.Equals(testing1));
        }

        [TestMethod]
        public void TestToStringWithSpaces()
        {
            Job anotherTest = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            
            //string[] autotest = anotherTest.ToString().StartsWith("\n");

            Assert.IsTrue(anotherTest.ToString().StartsWith("\n"));
            Assert.IsTrue(anotherTest.ToString().EndsWith("\n"));
            
        }

        [TestMethod]
        public void TestToStringPrintLabels()
        {
            Job testingAgain = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

           string testingMyPatience = "\nID: 11" +
                                       "\nName: Product Tester" +
                                       "\nEmployer: ACME" +
                                       "\nLocation: Desert" +
                                       "\nPosition Type: Quality Control" +
                                       "\nCore Competency: Persistence\n";

            Assert.AreEqual(testingMyPatience, testingAgain.ToString());


        }

        [TestMethod]
        public void TestToStringEmptyCells()
        {
            Job lastTest = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            string testingMyPatience = "\nID: 9" +
                                       "\nName: Data not available!" +
                                       "\nEmployer: Data not available!" +
                                       "\nLocation: Data not available!" +
                                       "\nPosition Type: Data not available!" +
                                       "\nCore Competency: Data not available!\n";
            Assert.AreEqual(testingMyPatience, lastTest);

        }
        
    }
}
