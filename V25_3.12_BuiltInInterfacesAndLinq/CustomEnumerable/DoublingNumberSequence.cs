using System.Collections;

namespace V25_3._12_BuiltInInterfacesAndLinq.CustomEnumerable;

public class DoublingNumberSequence : IEnumerable<int>, IEnumerator<int>
{
    private readonly int _maxNumber;
    public int Current { get; private set; }

    public DoublingNumberSequence(int startNumber, int maxNumber)
    {
        _maxNumber = maxNumber;
        Current = startNumber;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool MoveNext()
    {
        if (Current * 2 > _maxNumber)
            return false;

        Current *= 2;

        return true;
    }

    public void Reset()
    {
        
    }

    int IEnumerator<int>.Current => Current;

    object? IEnumerator.Current => Current;

    public void Dispose()
    {
        
    }
}