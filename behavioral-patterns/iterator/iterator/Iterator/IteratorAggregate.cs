using System.Collections;

namespace iterator;

public abstract class IteratorAggregate : IEnumerable
{
    public abstract IEnumerator GetEnumerator();
}
