namespace MyOntologyCode
{
    public class Identity
    {
        public string Name { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
    }
}
