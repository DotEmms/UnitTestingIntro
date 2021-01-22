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
        public void Test1()
        {
            // ARRANGE - verzamel data
            int numA = 5;
            int numB = 7;

            //ACT - doe iets
            int result = numA + numB;

            //ASSERT - vergelijk resultaat met verwacht resultaat
            Assert.AreEqual(12, result);
            
        }
       
    }
}