using System;
namespace TechJobsOO
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

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer empName, Location empLocation, PositionType jobType, CoreCompetency jobCoreComp) : this()
        {
            Name = name;
            EmployerName = empName;
            EmployerLocation = empLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreComp;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
