using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            public Job()
            {
                Id = nextId;
                nextId++;
            }

            public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
            {
                Name = name;
                EmployerName = employerName;
                EmployerLocation = employerLocation;
                JobType = jobType;
                JobCoreCompetency = jobCoreCompetency;
            }

        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string printName;
            string printEmployer;
            string printLocation;
            string printJobType;
            string printCompetency;

            if (Name == null) {
                printName = "Data not available";
            }
            else 
            {
                printName = Name;
            }

            if (EmployerName == null || EmployerName.ToString().Equals("")) {
                printEmployer = "Data not available";
            }
            else 
            {
                printEmployer = EmployerName.ToString();
            }

            if (EmployerLocation == null) {
                printLocation = "Data not available";
            }
            else 
            {
                printLocation = EmployerLocation.ToString();
            }

            if (JobType == null) {
                printJobType = "Data not available";
            }
            else 
            {
                printJobType = JobType.ToString();
            }

            if (JobCoreCompetency == null) {
                printCompetency = "Data not available";
            }
            else 
            {
                printCompetency = JobCoreCompetency.ToString();
            }

            return Environment.NewLine +
                $"ID: {Id}" + Environment.NewLine +
                $"Name: {printName}" + Environment.NewLine +
                $"Employer: {printEmployer}" + Environment.NewLine +
                $"Location: {printLocation}" + Environment.NewLine +
                $"Position Type: {printJobType}" + Environment.NewLine +
                $"Core Competency: {printCompetency}" + Environment.NewLine;
        }
    }
}

