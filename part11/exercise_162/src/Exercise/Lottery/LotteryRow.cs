namespace Exercise
{
  using System;
  using System.Collections.Generic;

  public class LotteryRow
  {
    private List<int> numbers;

    public LotteryRow()
    {
      this.RandomizeNumbers();
    }

    public List<int> Numbers()
    {
      return this.numbers;
    }

    public bool ContainsNumber(int number)
    {
      // Tests whether the number is already among the randomized numbers
      if (this.numbers.Contains(number))
      {
        return true;
      }
      return false;
    }

    public void RandomizeNumbers()
    {
      // initialize the list for numbers
      this.numbers = new List<int>();
      // Implement the randomization of the numbers by using the method ContainsNumber() here
      Random lotteryRow = new Random();

      for (int i = 0; i < 7; i++)
      {
        int randomNumber = lotteryRow.Next(1, 41);
        if(!this.numbers.Contains(randomNumber))
        {
          this.numbers.Add(randomNumber);
        }
      }
      this.numbers.Sort();
    }

  }
}