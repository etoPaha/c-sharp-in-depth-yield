using System.Collections;

namespace YieldPractice;

public class IterationSample : IEnumerable
{
    private object[] _values;
    private int _startingPoint;

    public IterationSample(object[] values, int startingPoint)
    {
        _values = values;
        _startingPoint = startingPoint;
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}