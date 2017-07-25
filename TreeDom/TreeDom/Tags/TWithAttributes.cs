using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDom.Tags.Attributes;

namespace TreeDom.Tags
{
    public sealed class TWithAttributes: IWithAttributes
    {
        private readonly ITag _origin;
        private readonly IEnumerable<ITAttribute> _attributes;

        public TWithAttributes(ITag origin)
            : this(origin, Enumerable.Empty<ITAttribute>())
        {
        }

        public TWithAttributes(ITag origin, ITAttribute attribute)
            :this(origin, new[] { attribute })
        {
        }

        public TWithAttributes(ITag origin, IEnumerable<ITAttribute> attributes)
        {
            _origin = origin;
            _attributes = attributes;
        }

        public string AsString()
        {
            return new Tag(Parts()).AsString();
        }

        public IEnumerable<IDomPart> Parts()
        {
            var parts = _origin.Parts().ToList();
            parts.AddRange(_attributes);
            return parts;
        }

        public ITag Unwrap()
        {
            return _origin.Unwrap();
        }

        public ITag Attr(ITAttribute attribute)
        {
            var attrs = _attributes.ToList();
            attrs.Add(attribute);
            return new TWithAttributes(_origin, attrs);
        }

        public ITAttribute Attr(string name)
        {
            var attrs = _attributes.Where(a => name.Equals(a.Name()));
            return attrs.Any() ? attrs.Last() : new TAEmpty(name);
        }

        public IEnumerable<ITAttribute> Attrs()
        {
            return _attributes;
        }

        public ITag Attrs(IEnumerable<ITAttribute> attributes)
        {
            var attrs = _attributes.ToList();
            attrs.AddRange(attributes);
            return new TWithAttributes(_origin, attrs);
        }
    }
}
