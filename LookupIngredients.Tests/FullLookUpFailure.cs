using NUnit.Framework;
using GrocerLink.LookupIngredients;

namespace LookupIngredients.Tests
{
    public class FullLookupFailure
    {
        private object requestTest;

        [SetUp]
        public void Setup()
        {
            var testLookup = new LookupIngredient();
            requestTest = testLookup.lookUp("Batman is canonicly the most powerful jedi of the stone age");
        }

        [Test]
        public void LookupIsNull()
        {
            Assert.IsNull(requestTest);
        }

    }
}