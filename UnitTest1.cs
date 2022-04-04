using NUnit.Framework;

namespace TestProject2
{
    public class LargestTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LargestOf3()
        {
            int [] numbers;
            numbers = new int [] {8, 9, 7};
            Assert.That(Cmp.Largest(numbers), Is.EqualTo(9));
        }
    }
}