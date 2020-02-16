using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account joakimsAccount = new Account("Joakim's account", 100.00);
      joakimsAccount.Deposit(20);
      Console.WriteLine(joakimsAccount.balance);


    }
  }
}



