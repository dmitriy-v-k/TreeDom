using NUnit.Framework;

namespace TreeDom.Tests
{
    [TestFixture()]
    public class RawTests
    {
        [Test()]
        public void AsStringTest()
        {
            StringAssert.AreEqualIgnoringCase("<Test>", new Raw("<Test>").AsString());
        }
    }
}