using System;

namespace nothinbutdotnetprep.infrastructure.ranges
{
  public class ExclusiveRangeWithNoUpperBound<T> : Range<T> 
  {
    T start;

    public ExclusiveRangeWithNoUpperBound(T start)
    {
      this.start = start;
    }

    public bool contains(IComparable<T> value)
    {
      return value.CompareTo(start) > 0;
    }
  }
}