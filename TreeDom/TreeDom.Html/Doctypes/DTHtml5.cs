using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDom.Tags.Attributes;

namespace TreeDom.Html.Doctypes
{
    public sealed class DTHtml5 : TDoctype
    {
        public DTHtml5()
            : base("html")
        {
        }

        protected override IEnumerable<IDomPart> AdditionalParts()
        {
            return new[] {
                new TAttribute(_topLevel)
            };
        }
    }
}
