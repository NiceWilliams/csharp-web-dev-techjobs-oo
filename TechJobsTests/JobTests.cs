using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job1 = new Job();
            Job test_job2 = new Job();
            Assert.AreEqual(test_job1.Id, test_job2.Id);
            Assert.IsFalse(test_job1.Id != test_job2.Id);
        }
    }
}
