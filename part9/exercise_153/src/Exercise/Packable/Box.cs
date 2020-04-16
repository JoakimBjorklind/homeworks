namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Box : IPackable
  {
    public int capacity;
    public List<IPackable> items;
    public Box(int i)
    {
      this.capacity = i;
      this.items = new List<IPackable>();
    }

    public void Add(IPackable item)
    {
      if ((Weight() + item.Weight()) <= this.capacity)
      {
        items.Add(item);
      }

    }

    public int Weight()
    {
      int totalWeight = 0;
      foreach (IPackable item in items)
      {
        totalWeight = totalWeight + item.Weight();
      }
      return totalWeight;
    }

    public override string ToString()
    {
      return items.Count + " items, total weight " + Weight() + " kg";
    }
  }
}