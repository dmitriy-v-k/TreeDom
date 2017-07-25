using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom
{
    public interface IPartGroup: IComposite
    {
        IPartGroup Add(IDomPart part);
    }
}
