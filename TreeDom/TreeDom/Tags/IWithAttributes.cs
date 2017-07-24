using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDom.Tags.Attributes;

namespace TreeDom.Tags
{
    interface IWithAttributes: ITag
    {
        ITag Attr(ITAttribute attribute);
        ITAttribute Attr(string name);

        IEnumerable<ITAttribute> Attrs();
        ITag Attrs(IEnumerable<ITAttribute> attributes);
    }
}
