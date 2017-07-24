using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tags
{
    public interface ITag : IComposite, IWrap<ITag>
    {
    }
}
