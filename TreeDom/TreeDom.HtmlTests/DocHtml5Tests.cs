using NUnit.Framework;
using TreeDom.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Html.Tests
{
    [TestFixture()]
    public class DocHtml5Tests
    {
        [Test()]
        public void DocHtml5Test()
        {
            throw new NotImplementedException();
        }

        [Test()]
        public void AddPartTest()
        {
            throw new NotImplementedException();
        }

        [Test()]
        public void AddToBodyTest()
        {
            var expected = "<!DOCTYPE html><html><head>head</head><body>bodybody1</body></html>";
            var act = new DocHtml5(
                new Document(
                    new Raw("body")
                ),
                new Raw("head")
            )
            .AddToBody(
                new Raw("body1")
            );
            StringAssert.AreEqualIgnoringCase(expected, act.AsString());
        }

        [Test()]
        public void AddToHeadTest()
        {
            var expected = "<!DOCTYPE html><html><head>headhead1</head><body>body</body></html>";
            var act = new DocHtml5(
                new Document(
                    new Raw("body")
                ),
                new Raw("head")
            )
            .AddToHead(
                new Raw("head1")
            );
            StringAssert.AreEqualIgnoringCase(expected, act.AsString());
        }

        [Test()]
        public void AsStringTest()
        {
            var expected = "<!DOCTYPE html><html><head>head</head><body>body</body></html>";
            var act = new DocHtml5(
                new Document(
                    new Raw("body")
                ),
                new Raw("head")
            ).AsString();
            StringAssert.AreEqualIgnoringCase(expected, act);
        }

        [Test()]
        public void PartsTest()
        {
            throw new NotImplementedException();
        }
    }
}