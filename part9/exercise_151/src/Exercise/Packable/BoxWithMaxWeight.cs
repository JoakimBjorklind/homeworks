namespace Exercise
{
  using System.Collections.Generic;
  public class BoxWithMaxWeight : Box
  {
    private int capacity;
    public BoxWithMaxWeight(int capacity)
    {
      this.capacity = capacity;
    }

    public override void Add(Item item)
    {
    }


    public override bool IsInBox(Item item)
    {
      return false;
    }
  }
}