using NUnit.Framework;
using GrocerLink.LookupIngredients;

namespace LookupIngredients.Tests
{
    public class LookupSuccess
    {
        private object steakEntry;
        private object garlicEntry;

        [SetUp]
        public void Setup()
        {
            var testLookup = new LookupIngredient();
            steakEntry = testLookup.lookUp("steak");
            garlicEntry = testLookup.lookUpFullDocument("garlic");
        }

        [Test]
        public void LookupIsNotNull()
        {
            Assert.IsNotNull(steakEntry);
        }

        [Test]
        public void LookupContainsCorrectASIN()
        {
            Assert.IsTrue(steakEntry.ToString().Contains("B001DTOCBK"));
        }

        [Test]
        public void FullLookupContainsASIN()
        {
            Assert.IsTrue(garlicEntry.ToString().Contains("ASIN"));
        }
    }
}