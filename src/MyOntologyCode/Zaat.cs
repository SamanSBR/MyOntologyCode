namespace MyOntologyCode
{
    /// <summary>
    /// "Zaat" is the abstract root of all conceptual entities in the system.
    /// It represents the unknown essence. It cannot be instantiated.
    /// </summary>
    public abstract class Zaat
    {
        public abstract string Essence { get; }

        public virtual string Describe()
        {
            return "This is the unknowable root of existence — Zaat.";
        }
    }
}
