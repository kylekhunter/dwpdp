using System;

namespace nothinbutdotnetprep.infrastructure.ranges
{
  public interface Range<T>
  {
    bool contains(IComparable<T> value);
  }
}