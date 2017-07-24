using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom
{
    public interface IComposite: IDomPart
    {
        IEnumerable<IDomPart> Parts();
    }
}
