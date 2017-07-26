using NUnit.Framework;

namespace TreeDom.Tags.Tests
{
    [TestFixture()]
    public class TagTests
    {
        [Test()]
        public void Tag_AsString_Shoud_be_fine()
        {
            var tag = new Tag("test");

            StringAssert.AreEqualIgnoringCase("<test>", tag.AsString());
        }

        [Test()]
        public void Tag_Parts_Shoud_be_fine()
        {
            var name = new Raw("test");
            var tag = new Tag(name);

            CollectionAssert.AreEqual(new[] { name }, tag.Parts());
        }

        [Test()]
        public void Tag_Unwrap_Shoud_be_fine()
        {
            var tag = new Tag("test");

            Assert.AreEqual(tag, tag.Unwrap());
        }
    }
}