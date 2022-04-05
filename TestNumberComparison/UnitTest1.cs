using System;
using NUnit.Framework;

namespace NumberComparison
{
    [TestFixture]
<<<<<<< Updated upstream
    [Category("NumberComparison")]
    public class Tests
=======
    public class TestsNumberComparison
>>>>>>> Stashed changes
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("ArrayEdge")]
        public void LargestOf3()
        {
            int[] numbers;
            //tests if 9 is returned at every position
            numbers = new int[] {8, 9, 7};
            Assert.That(Cmp.Largest(numbers), Is.EqualTo(9));
            numbers = new int[] {7, 8, 9 };
            Assert.That(Cmp.Largest(numbers), Is.EqualTo(9));
            numbers = new int[] { 9, 8, 7};
            Assert.That(Cmp.Largest(numbers), Is.EqualTo(9));
        }

        [Test]
        [Category("NegativeValues")]
        public void TestForNegativeValues()
        {
            int[] numbers;
            //try every order of the numbers and run test
            numbers = new int[] { -8, -9, -7 };
            Assert.That(Cmp.Largest(numbers), Is.EqualTo(-7));
            numbers = new int[] { -7, -8, -9 };
            Assert.That(Cmp.Largest(numbers), Is.EqualTo(-7));
            numbers = new int[] { -7, -7, -8 };
            Assert.That(Cmp.Largest(numbers), Is.EqualTo(-7));
        }

        [Test]
        public void TestForMoreValuesIncluding0()
        {
            int[] numbers;
            numbers = new int[] { -8, 0, 100, -9, -7 };
            Assert.That(Cmp.Largest(numbers), Is.EqualTo(100));
        }

        [Test]
        [Category("Empty")]
        public void Empty()
        {
            int[] values = Array.Empty<int>();
            Assert.Throws<ArgumentException>(() => Cmp.Largest(values));
        }
    }
}