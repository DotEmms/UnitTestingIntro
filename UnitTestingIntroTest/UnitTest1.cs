using NUnit.Framework;

namespace UnitTestingIntroTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenTwoIntegers_WhenMultiplying_ThenResultEqualToMultiplication()
        {
            // ARRANGE - verzamel data
            int numA = 5;
            int numB = 7;

            //ACT - doe iets
            int result = numA * numB;

            //ASSERT - vergelijk resultaat met verwacht resultaat
            Assert.AreEqual(35, result);
        }
        [TestCase(5,7,12)]
        [TestCase(10, 15, 25)]
        [TestCase(2, 2, 4)]
        public void GivenTwoIntegers_WhenAdding_ThenResultEqualToAddition(int numA, int numB, int expectedResult)
        {
            // ARRANGE - verzamel data
            //See user input

            //ACT - doe iets
            int result = numA + numB;

            //ASSERT - vergelijk resultaat met verwacht resultaat
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void EverythingIsFine()
        {
            Assert.True(false);
        }
    }
}