using System;
using System.Collections.Generic;
using System.Linq;
using TreeDom.Extensions;

namespace TreeDom
{
    public sealed class PartsGroup : IPartGroup
    {
        private readonly IEnumerable<IDomPart> _parts;

        public PartsGroup()
            : this(Enumerable.Empty<IDomPart>())
        {
        }

        public PartsGroup(IDomPart part)
            : this(new[] { part })
        {
        }

        public PartsGroup(IEnumerable<IDomPart> parts)
        {
            _parts = parts;
        }

        public PartsGroup(params IDomPart[] parts)
        {
            _parts = parts;
        }

        public IPartGroup Add(IDomPart part)
        {
            return new PartsGroup(_parts.Add(part));
        }

        public string AsString()
        {
            return string.Concat(_parts.Select(p => p.AsString()));
        }

        public IEnumerable<IDomPart> Parts()
        {
            return _parts;
        }
    }
}
