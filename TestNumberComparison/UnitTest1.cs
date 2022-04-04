using NUnit.Framework;

namespace TestNumberComparison
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LargestOf3()
        {
            int[] numbers;
            //try every order of the numbers and run test
            numbers = new int[] {8, 9, 7};
            Assert.That(Cmp.Largest(numbers), Is.EqualTo(9));
        }

        [Test]
        public void TestForNegativeValues()
        {
            int[] numbers;
            //try every order of the numbers and run test
            numbers = new int[] { -8, -9, -7 };
            Assert.That(Cmp.Largest(numbers), Is.EqualTo(-7));
        }

        [Test]
        public void TestForMoreValuesIncluding0()
        {
            int[] numbers;
            //try every order of the numbers and run test
            numbers = new int[] { -8, 0, 100, -9, -7 };
            Assert.That(Cmp.Largest(numbers), Is.EqualTo(100));
        }
    }
}