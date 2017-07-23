using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeDom
{
    public sealed class Document : IDocument
    {
        private readonly IEnumerable<IDomPart> _domParts;
        public Document(IEnumerable<IDomPart> domParts)
        {
            _domParts = domParts;
        }
        public string AsString()
        {
            return string.Concat(_domParts);
        }

        public IDocument WithDocumentPart(IDomPart domPart)
        {
            return WithDocumentParts(new[] { domPart });
        }

        public IDocument WithDocumentParts(IEnumerable<IDomPart> domParts)
        {
            return new Document(_domParts.Concat(domParts));
        }
    }
}
