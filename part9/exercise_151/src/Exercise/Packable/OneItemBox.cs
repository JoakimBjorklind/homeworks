namespace Exercise
{
  public class OneItemBox : Box
  {
    private Item inBox;
    public OneItemBox()
    {
      this.inBox = null;
    }

    public override void Add(Item item)
    {
      if (this.inBox == null)
      {
        this.inBox = item;
      }

    }


    public override bool IsInBox(Item item)
    {
      if  (this.inBox.Equals(item))
      {
        return true;
      }
      return false;
    }
  }
}