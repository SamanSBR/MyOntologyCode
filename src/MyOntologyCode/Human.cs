namespace MyOntologyCode
{
    public class Human : Zaat
    {
        public Identity Identity { get; set; }
        public List<Experience> Experiences { get; set; } = new();
        public List<Emotion> Emotions { get; set; } = new();

        public Human(string name)
        {
            Identity = new Identity { Name = name };
        }

        public void Feel(Emotion emotion) => Emotions.Add(emotion);

        public void Live(Experience experience) => Experiences.Add(experience);

        public override string Essence => "Ensaan";
    }
}
