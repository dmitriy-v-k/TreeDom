using NUnit.Framework;

namespace TreeDom.Tests
{
    [TestFixture()]
    public class DocumentTests
    {
        [Test()]
        public void AsStringTest()
        {
            var doc = new Document(
                new[] {
                    new Raw("<test>"),
                    new Raw("<test2>")
                }    
            );
            StringAssert.AreEqualIgnoringCase("<test><test2>", doc.AsString());
        }
    }
}