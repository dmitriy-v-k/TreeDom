using NUnit.Framework;
using TreeDom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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