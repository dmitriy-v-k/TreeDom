using System.Collections.Generic;

namespace TreeDom
{
    public interface IDocument: IComposite
    {
        IDocument WithPart(IDomPart part);
    }
}
