using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeDom
{
    public sealed class Document : IDocument
    {
        private readonly IEnumerable<IDomPart> _domParts;
        public Document(IDomPart domPart)
            : this(new[]{ domPart })
        {
        }

        public Document(IEnumerable<IDomPart> domParts)
        {
            _domParts = domParts;
        }

        public string AsString()
        {
            return string.Concat(Parts().Select(p => p.AsString()));
        }

        public IDocument WithPart(IDomPart part)
        {
            var parts = _domParts.ToList();
            parts.Add(part);
            return new Document(parts);
        }

        public IEnumerable<IDomPart> Parts()
        {
            return _domParts.ToList();
        }
    }
}
