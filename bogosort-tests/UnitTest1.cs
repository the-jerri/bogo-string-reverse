using bogosort;
namespace bogosort_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReverseString()
        {
            var teststring = "Testing 123";
            var reversedString = "321 gnitseT";
            if (teststring.Reverse() == reversedString)
                Assert.Pass("String was reversed correctly");
            else 
                Assert.Fail("String was not reversed correctly");
        }
    }
}