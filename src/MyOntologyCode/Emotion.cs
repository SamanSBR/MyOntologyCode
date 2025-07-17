namespace MyOntologyCode
{
    public class Emotion
    {
        public string Type { get; set; }
        public float Intensity { get; set; }

        public Emotion(string type, float intensity)
        {
            Type = type;
            Intensity = intensity;
        }

        public string React()
        {
            return $"Feeling {Type} at intensity {Intensity}";
        }
    }
}
