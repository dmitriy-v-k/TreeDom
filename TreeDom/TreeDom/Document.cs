using System;
using System.Collections.Generic;
using System.Linq;
using TreeDom.Extensions;

namespace TreeDom
{
    public sealed class Document : IDocument<Document>
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

        public Document WithPart(IDomPart part)
        {
            return new Document(Parts().Add(part));
        }

        public IEnumerable<IDomPart> Parts()
        {
            return _domParts.ToList();
        }
    }
}
