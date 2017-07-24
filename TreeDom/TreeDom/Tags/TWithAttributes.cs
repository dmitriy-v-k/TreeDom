using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDom.Tags.Attributes;

namespace TreeDom.Tags
{
    public sealed class TWithAttributes: ITag
    {
        private readonly ITag _origin;
        private readonly IEnumerable<ITAttribute> _attributes;

        public TWithAttributes(ITag origin, IEnumerable<ITAttribute> attributes)
        {
            _origin = origin;
            _attributes = attributes;
        }

        public string AsString()
        {
            return string.Join(string.Empty, Parts());
        }

        public IEnumerable<IDomPart> Parts()
        {
            var parts = Unwrap().Parts().ToList();
            parts.AddRange(_attributes);
            return parts;
        }

        public ITag Unwrap()
        {
            return _origin.Unwrap();
        }
    }
}
