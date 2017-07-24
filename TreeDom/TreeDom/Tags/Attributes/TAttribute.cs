using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tags.Attributes
{
    public sealed class TAttribute : ITAttribute
    {
        private readonly string _name;

        public TAttribute(string name)
        {
            _name = name;
        }
        public string AsString()
        {
            return string.Format(" {0}", _name);
        }

        public string Name()
        {
            return _name;
        }
    }
}
