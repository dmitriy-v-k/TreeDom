using System.Collections.Generic;

namespace TreeDom
{
    public interface IDocument<T>: IComposite
    {
        T WithPart(IDomPart part);
    }
}
