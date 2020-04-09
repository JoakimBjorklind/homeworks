using System;
using System.Collections.Generic;

namespace Exercise
{
  public class IOU
  {
     private Dictionary<string, int> iou;
     public IOU()
    {
      this.iou = new Dictionary<string, int>();
    }
    public void ChangeDebt(string toWhom, int amount)
    {
      if (this.iou.ContainsKey(toWhom))
      {
        if (iou[toWhom] + amount >= 0)
        {
          iou[toWhom] = iou[toWhom] + amount;
        }
        else
        {
          iou[toWhom] = 0;
        }
      }
      else if (amount > 0)
      {
        iou.Add(toWhom, amount);
      }
      else
      {
        iou.Add(toWhom, 0);
      }
    }

    public int HowMuchDoIOweTo(string toWhom)
    {
      if (this.iou.ContainsKey(toWhom))
      {
        return this.iou[toWhom];
      }
      else
      {
      return 0;
      }
    }
  }
}
