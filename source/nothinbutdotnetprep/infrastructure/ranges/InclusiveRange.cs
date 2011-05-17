using System;

namespace nothinbutdotnetprep.infrastructure.ranges
{
  public class InclusiveRange<T> : Range<T>
  {
    T start;
    T end;

    public InclusiveRange(T start, T end)
    {
      this.start = start;
      this.end = end;
    }

    public bool contains(IComparable<T> value)
    {
      return value.CompareTo(start) >= 0 && value.CompareTo(end) <= 0;
    }
  }
}