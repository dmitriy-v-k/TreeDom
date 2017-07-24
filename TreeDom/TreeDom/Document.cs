using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeDom
{
    public sealed class Document : IComposite
    {
        private readonly IEnumerable<IDomPart> _domParts;
        public Document(IEnumerable<IDomPart> domParts)
        {
            _domParts = domParts;
        }
        public string AsString()
        {
            return string.Join(string.Empty, Parts().Select(p => p.AsString()));
        }

        public IEnumerable<IDomPart> Parts()
        {
            return _domParts.ToList();
        }
    }
}
