using System;

namespace exercise_108
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;
        }

        public override string ToString()
        {
            // write code here
            return "The card has a balance of " + this.balance + " euros";
        }
        public void EatLunch()
        {
           if (this.balance > 10.60)
           {
             this.balance = this.balance - 10.60;
           }
        }
        public void DrinkCoffee()
        {
          if (this.balance > 2.0)
          {
          this.balance = this.balance -2.0;
          }
        }


    }

}    