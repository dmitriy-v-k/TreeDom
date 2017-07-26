using NUnit.Framework;
using TreeDom.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDom.Html.Doctypes;
using TreeDom.Tags;

namespace TreeDom.Html.Tests
{
    [TestFixture()]
    public class DocHtml5Tests
    {
        [Test()]
        public void DocHtml5_WithPart_Should_be_fine()
        {
            const string expected = "<!DOCTYPE html><html><head>head</head><body>bodybody1</body></html>";
            var act = new DocHtml5(
                new Raw("head"),
                new Raw("body")
            )
            .WithPart(
                new Raw("body1")
            );
            StringAssert.AreEqualIgnoringCase(expected, act.AsString());
        }

        [Test()]
        public void DocHtml5_AddToBody_Should_be_fine()
        {
            const string expected = "<!DOCTYPE html><html><head>head</head><body>bodybody1</body></html>";
            var act = new DocHtml5(
                new Raw("head"),
                new Raw("body")
            )
            .AddToBody(
                new Raw("body1")
            );
            StringAssert.AreEqualIgnoringCase(expected, act.AsString());
        }

        [Test()]
        public void DocHtml5_AddToHead_Should_be_fine()
        {
            const string expected = "<!DOCTYPE html><html><head>headhead1</head><body>body</body></html>";
            var act = new DocHtml5(
                new Raw("head"),
                new Raw("body")
            )
            .AddToHead(
                new Raw("head1")
            );
            StringAssert.AreEqualIgnoringCase(expected, act.AsString());
        }

        [Test()]
        public void DocHtml5_AsString_Should_be_fine()
        {
            const string expected = "<!DOCTYPE html><html><head>head</head><body>body</body></html>";
            var act = new DocHtml5(
                new Raw("head"),
                new Raw("body")
            ).AsString();
            StringAssert.AreEqualIgnoringCase(expected, act);
        }

        [Test()]
        public void DocHtml5_Parts_Should_be_fine()
        {
            var act = new DocHtml5(
                new Raw("head"),
                new Raw("body")
            ).Parts();

            var expected = new List<IDomPart>() {
                new DTHtml5(),
                new TWithContent(
                    new Tag("html"),
                    new PartsGroup(
                        new TWithContent(
                            new Tag("head"),
                            new PartsGroup(
                                new Raw("head")
                            )
                        ),
                        new TWithContent(
                            new Tag("body"),
                            new PartsGroup(
                                new Raw("body")
                            )
                        )
                    )
                )
            };

            CollectionAssert.AreEqual(expected.Select(e => e.AsString()), act.Select(e => e.AsString()));
        }
    }
}