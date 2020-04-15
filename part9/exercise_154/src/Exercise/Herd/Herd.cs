namespace Exercise
{
  using System.Collections.Generic;
  using System.Text;
  public class Herd : IMovable
  {
    private List<IMovable> objects;

    public Herd()
    {
      this.objects = new List<IMovable>();
    }

    public void AddToHerd(IMovable m)
    {
      this.objects.Add(m);
    }

    public void Move(int dx, int dy)
    {
      foreach (IMovable member in objects)
      {
        member.Move(dx, dy);
      }
    }

    public override string ToString()
    {
      // found this solution from stackoverflow. had to add the using.System.Text for it to get
      // it to work with the StringBuilder. Not exactly sure how this thing works but it printed 
      // out the right way with dotnet run and it passed the dotnet test.
      StringBuilder strBuilder = new StringBuilder();
      foreach (IMovable member in objects)
      {
         strBuilder.AppendLine(member.ToString());
      }
      return strBuilder.ToString();
    }
  }
}