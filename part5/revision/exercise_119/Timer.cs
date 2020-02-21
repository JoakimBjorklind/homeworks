using System;

namespace exercise_119
{
  public class Timer
{
  
  private ClockHand centiSeconds;
  private ClockHand seconds;

  public Timer()
  {
    this.centiSeconds = new ClockHand(100);
   
    this.seconds = new ClockHand(60);
  }

  public void Advance()
  {
    this.centiSeconds.Advance();

    if (this.centiSeconds.value == 0)
    {
      this.seconds.Advance();

      
    }
  }

  public override string ToString()
  {
    return seconds + ":" + centiSeconds;
  }
}
}