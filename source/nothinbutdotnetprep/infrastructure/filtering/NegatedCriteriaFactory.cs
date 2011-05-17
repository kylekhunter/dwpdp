namespace nothinbutdotnetprep.infrastructure.filtering
{
  public class NegatedCriteriaFactory<ItemToFilter, PropertyType> : ICreateSpecifications<ItemToFilter, PropertyType>
  {
    ICreateSpecifications<ItemToFilter, PropertyType> original;

    public NegatedCriteriaFactory(ICreateSpecifications<ItemToFilter, PropertyType> original)
    {
      this.original = original;
    }

    public IMatchAn<ItemToFilter> equal_to(PropertyType value)
    {
      return original.equal_to(value).not();
    }

    public IMatchAn<ItemToFilter> equal_to_any(params PropertyType[] values)
    {
      return original.equal_to_any(values).not();
    }

    public IMatchAn<ItemToFilter> create_using(IMatchAn<PropertyType> criteria)
    {
      return original.create_using(criteria).not();
    }

    public IMatchAn<ItemToFilter> greater_than(PropertyType value)
    {
        return original.greater_than(value).not();
    }

    public IMatchAn<ItemToFilter> between(PropertyType start, PropertyType end)
    {
        return original.between(start, end).not();
    }
  }
}