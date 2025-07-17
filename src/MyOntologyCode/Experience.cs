namespace MyOntologyCode
{
    public class Experience
    {
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string Description { get; set; }

        public Experience(string desc)
        {
            Description = desc;
        }
    }
}
