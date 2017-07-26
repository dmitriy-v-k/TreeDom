using NUnit.Framework;
using System.Linq;

namespace TreeDom.Tags.Tests
{
    [TestFixture()]
    public class TCloseTests
    {
        [Test()]
        public void TClose_AsString_Should_be_fine()
        {
            var tag = new TClose(
                new Tag(
                    new[] {
                        new Raw("Test")
                    }
                )
            );

            StringAssert.AreEqualIgnoringCase("</test>", tag.AsString());
        }

        [Test()]
        public void TClose_Parts_Should_be_fine()
        {
            var name = new Raw("test");
            var tag = new Tag(name);
            var close = new TClose(tag);

            CollectionAssert.AreEqual((new[] { new Raw("/"), name }).Select(p => p.AsString()), close.Parts().Select(p => p.AsString()));
        }

        [Test()]
        public void TClose_Unwrap_Should_be_fine()
        {
            var tag = new Tag(
                new Raw("Test")
            );
            var close = new TClose(tag);

            Assert.AreEqual(tag, close.Unwrap());
        }
    }
}