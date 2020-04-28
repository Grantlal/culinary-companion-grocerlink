using NUnit.Framework;
using GrocerLink.LookupIngredients;

namespace LookupIngredients.Tests
{
    public class FullLookupSuccess
    {
        private object requestTest;

        [SetUp]
        public void Setup()
        {
            var testLookup = new LookupIngredient();
            requestTest = testLookup.lookUpFullDocument("garlic");
        }

        [Test]
        public void LookupIsnotNull()
        {
            Assert.IsNotNull(requestTest);
        }

        [Test]
        public void LookupContainsASIN()
        {
            Assert.IsTrue(requestTest.ToString().Contains("ASIN"));
        }

        [Test]
        public void LookupContainsIngredient()
        {
            Assert.IsTrue(requestTest.ToString().Contains("garlic"));
        }

        [Test]
        public void LookupContainsCorrectASIN()
        {
            Assert.IsTrue(requestTest.ToString().Contains("B00J9YNTMO"));
        }
    }
}