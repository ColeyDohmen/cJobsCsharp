namespace cJobs.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }
    }

    public class ContractorJobViewModel : Job
    {
        public int ContractorJobId { get; set; }

    }
}