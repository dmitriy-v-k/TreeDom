using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tags.Attributes
{
    public sealed class Attribute : ITAttribute
    {
        private readonly string _name;

        public Attribute(string name)
        {
            _name = name;
        }
        public string AsString()
        {
            return _name;
        }
    }
}
