using NUnit.Framework;
using GrocerLink.LookupIngredients;

namespace LookupIngredients.Tests
{
    public class LookupFailure
    {
        private object requestTest;

        [SetUp]
        public void Setup()
        {
            var testLookup = new LookupIngredient();
            requestTest = testLookup.lookUp("Garden Gnome");
        }

        [Test]
        public void LookupIsNull()
        {
            Assert.IsNull(requestTest);
        }

    }
}