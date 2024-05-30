
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //testing objects
        Job job1 = new Job();
        Job job2 = new Job();
        Job job3 = new("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job job4 = new("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(1, job1.Id);
            Assert.AreEqual(2, job2.Id);
            Assert.AreEqual(job1.Id + 1, job2.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.ToString());
            Assert.AreEqual("Desert", job3.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job3.JobType.ToString());
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.ToString());
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Id.Equals(job4.Id));
        }
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Console.WriteLine(job3.ToString());
            Console.WriteLine(job3.ToString());
            Assert.AreEqual(
                job3.ToString()
            ,
                Environment.NewLine +
                $"ID: 3" + Environment.NewLine +
                $"Name: Product tester" + Environment.NewLine +
                $"Employer: ACME" + Environment.NewLine +
                $"Location: Desert" + Environment.NewLine +
                $"Position Type: Quality control" + Environment.NewLine +
                $"Core Competency: Persistence" + Environment.NewLine
            );
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.AreEqual(
                Environment.NewLine +
                $"ID: {job1.Id}" + Environment.NewLine +
                $"Name: Data not available" + Environment.NewLine +
                $"Employer: Data not available" + Environment.NewLine +
                $"Location: Data not available" + Environment.NewLine +
                $"Position Type: Data not available" + Environment.NewLine +
                $"Core Competency: Data not available" + Environment.NewLine,
                job1.ToString()
            );
        }
    }
}

