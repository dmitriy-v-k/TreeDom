using NUnit.Framework;
using TreeDom.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tags.Tests
{
    [TestFixture()]
    public class TagTests
    {
        [Test()]
        public void AsStringTest()
        {
            var tag = new Tag(
                new[] {
                    new Raw("Test")
                }    
            );

            StringAssert.AreEqualIgnoringCase("<test>", tag.AsString());
        }

        [Test()]
        public void PartsTest()
        {
            throw new NotImplementedException();
        }

        [Test()]
        public void UnwrapTest()
        {
            throw new NotImplementedException();
        }
    }
}