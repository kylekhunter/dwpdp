﻿namespace nothinbutdotnetprep.infrastructure.filtering
{
  public interface ICreateSpecifications<ItemToFilter, PropertyType>
  {
    IMatchAn<ItemToFilter> equal_to(PropertyType value);
    IMatchAn<ItemToFilter> equal_to_any(params PropertyType[] values);
    IMatchAn<ItemToFilter> create_using(IMatchAn<PropertyType> criteria);
    IMatchAn<ItemToFilter> greater_than(PropertyType value);
    IMatchAn<ItemToFilter> between(PropertyType start, PropertyType end);
  }
}