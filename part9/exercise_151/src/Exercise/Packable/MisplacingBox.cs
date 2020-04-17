namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class MisplacingBox : Box
  {
    private List<Item> itemsInBox;
    public MisplacingBox()
    {
      this.itemsInBox = new List<Item>();
    }

    public override void Add(Item item)
    {
      this.itemsInBox.Add(item);
    }


    public override bool IsInBox(Item item)
    {
      return false;
    }
  }
}