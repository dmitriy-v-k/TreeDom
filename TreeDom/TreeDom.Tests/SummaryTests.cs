using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDom.Tags;
using TreeDom.Tags.Attributes;

namespace TreeDom.Tests
{
    [TestFixture]
    public class SummaryTests
    {
        private IDomPart _doc;
        [SetUp]
        public void Setup()
        {
            _doc = new Document(
                new List<IDomPart> {
                    new Tag("!DOCTYPE html"),
                    new TWithContent(
                        new Tag("html"),
                        new TWithContent(
                            new TWithAttributes(
                                new Tag("head"),
                                new [] {
                                    new TAWithValue(
                                        new TAttribute("lang"),
                                        "ru_RU"    
                                    )
                                }
                            ),
                            new Raw("test")
                        )    
                    )
                }    
            );
        }

        [Test()]
        public void AsStringTest()
        {
            StringAssert.AreEqualIgnoringCase("<!DOCTYPE html><html><head lang=\"ru_RU\" >test</head></html>", _doc.AsString());
        }
    }
}
