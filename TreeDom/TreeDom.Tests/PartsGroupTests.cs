using NUnit.Framework;
using System.Linq;
using TreeDom.Extensions;

namespace TreeDom.Tests
{
    [TestFixture()]
    public class PartsGroupTests
    {
        [Test()]
        public void PartsGroup_Add_Should_be_fine()
        {
            var testItem = new Raw("test1");

            var group = new PartsGroup()
                .Add(testItem)
                .Add(testItem);

            var expect = Enumerable
                .Empty<IDomPart>()
                .Add(testItem)
                .Add(testItem);

            CollectionAssert.AreEqual(expect, group.Parts());
        }

        [Test()]
        public void PartsGroup_AsString_Should_be_fine()
        {
            var group = new PartsGroup(
                new[] {
                    new Raw("test1"),
                    new Raw("test2")
                }
            );
            StringAssert.AreEqualIgnoringCase("test1test2", group.AsString());
        }

        [Test()]
        public void PartsGroup_AsString_Should_be_fine_All()
        {
            var actual = new PartsGroup(
                new Raw("test1")
            )
            .Add(
                new Raw("test2")
            );

            var expected = new PartsGroup(
                new[] {
                    new Raw("test1"),
                    new Raw("test2")
                }
            );

            StringAssert.AreEqualIgnoringCase(expected.AsString(), actual.AsString());
        }
    }
}