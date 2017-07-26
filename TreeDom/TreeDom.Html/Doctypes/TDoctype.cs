using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDom.Extensions;
using TreeDom.Tags;
using TreeDom.Tags.Attributes;

namespace TreeDom.Html.Doctypes
{
    public abstract class TDoctype : ITag
    {
        protected readonly string _topLevel;
        protected readonly string _pub;
        protected readonly string _reg;
        protected readonly string _org;
        protected readonly string _type;
        protected readonly string _name;
        protected readonly string _lang;
        protected readonly string _url;

        protected TDoctype(string topLevel)
            : this(topLevel, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty)
        {
        }

        protected TDoctype(string topLevel, string pub, string reg,
            string org, string type, string name, string lang, string url)
        {
            _topLevel = topLevel;
            _pub = pub;
            _reg = reg;
            _org = org;
            _type = type;
            _name = name;
            _lang = lang;
            _url = url;
        }

        public string AsString()
        {
            return new Tag(Parts()).AsString();
        }

        public IEnumerable<IDomPart> Parts()
        {
            var parts = new List<IDomPart>() {
                new Raw("!DOCTYPE")
            };
            parts.AddRange(AdditionalParts());
            return parts;
        }

        public ITag Unwrap()
        {
            return this;
        }

        protected virtual IEnumerable<IDomPart> AdditionalParts()
        {
            return new List<IDomPart>() {
                new TAttribute(_topLevel),
                new TAttribute(_pub),
                new TAttribute(string.Format("\"{0}//{1}//{2} {3}//{4}\"",_reg,_org,_type,_name,_lang)),
                new TAttribute(string.Format("\"{0}\"",_url))
            };
        }
    }
}
