using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom
{
    public sealed class PartsGroup : IDomPart
    {
        private readonly IEnumerable<IDomPart> _parts; 
        public PartsGroup(IEnumerable<IDomPart> parts)
        {
            _parts = parts;
        }
        public string AsString()
        {
            return string.Join(string.Empty, _parts.Select(p => p.AsString()));
        }
    }
}
