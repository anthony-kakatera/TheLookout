namespace UnitTest
{
    public class Tests
    {    
        [SetUp]
        public void Setup()
        {}

        [Test]
        public void Test1()
        {
            //sample input
            var result = TheLookout.TheLookout.theLookout("cheese", "a", "eastern");
            //running unit test
            Assert.That(result, Is.EqualTo("Ahoy, Captain, a cheese off to eastern"));
        }

        [Test]
        public void Test2()
        {
            //sample input
            var result = TheLookout.TheLookout.theLookout("apple", "a", "southern");
            //running unit test
            Assert.That(result, Is.EqualTo("Ahoy, Captain, an apple off to southern"));
        }
    }
}