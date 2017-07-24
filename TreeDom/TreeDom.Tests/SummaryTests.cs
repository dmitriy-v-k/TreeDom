using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDom.Tags;

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
                    new Tag(
                        new [] {
                            new Raw("!DOCTYPE html")
                        }
                    ),
                    new TWithContent(
                        new Tag(
                            new [] {
                                new Raw("html")
                            }
                        ),
                        new TWithContent(
                            new Tag(
                                new[] {
                                    new Raw("head")
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
            StringAssert.AreEqualIgnoringCase("<!DOCTYPE html><html><head>test</head></html>", _doc.AsString());
        }
    }
}
