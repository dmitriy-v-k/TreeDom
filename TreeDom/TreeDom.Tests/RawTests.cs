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
    public class RawTests
    {
        [Test()]
        public void AsStringTest()
        {
            StringAssert.AreEqualIgnoringCase("<Test>", new Raw("<Test>").AsString());
        }
    }
}