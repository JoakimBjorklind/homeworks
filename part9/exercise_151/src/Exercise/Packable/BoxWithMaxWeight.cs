namespace Exercise
{
  using System.Collections.Generic;
  public class BoxWithMaxWeight : Box
  {
    private int capacity;
    private int boxedItemsTotalWeight;
    private List<Item> boxedItems;
    public BoxWithMaxWeight(int capacity)
    {
      this.capacity = capacity;
      this.boxedItemsTotalWeight = 0;
      this.boxedItems = new List<Item>();
    }

    public override void Add(Item item)
    {
      if (this.capacity - this.boxedItemsTotalWeight >= item.weight)
      {
      boxedItems.Add(item);
      this.boxedItemsTotalWeight += item.weight;
      }

    }


    public override bool IsInBox(Item item)
    {
      return this.boxedItems.Contains(item);
    }
  }
}