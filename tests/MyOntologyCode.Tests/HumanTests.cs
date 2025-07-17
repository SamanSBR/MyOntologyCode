using Xunit;

namespace MyOntologyCode.Tests
{
    public class HumanTests
    {
        [Fact]
        public void Human_HasIdentity_WhenCreated()
        {
            var h = new Human("Ali");
            Assert.Equal("Ali", h.Identity.Name);
        }

        [Fact]
        public void Human_CanFeelEmotion()
        {
            var h = new Human("Sara");
            h.Feel(new Emotion("Joy", 0.9f));
            Assert.Single(h.Emotions);
        }
    }
}
