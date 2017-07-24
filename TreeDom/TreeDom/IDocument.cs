using System.Collections.Generic;

namespace TreeDom
{
    public interface IDocument: IComposite
    {
        IDocument AddPart(IDomPart part);
    }
}
