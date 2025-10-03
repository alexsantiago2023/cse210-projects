public class Resume
{
    public string _name;

    public List<Job> Jobs = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Jobs:");
        
        foreach (Job job in Jobs)
        {
            job.DisplayJobDetails();
        }
    }
}