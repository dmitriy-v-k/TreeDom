using NUnit.Framework;
using TreeDom.Html.Doctypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Html.Doctypes.Tests
{
    [TestFixture()]
    public class DTHtml5Tests
    {
        [Test()]
        public void Html5_Doctype_Should_be_generated_fine()
        {
            StringAssert.AreEqualIgnoringCase("<!DOCTYPE html>",new DTHtml5().AsString());
        }
    }
}