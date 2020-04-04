using System;

namespace exercise_109
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
                this.balance = this.balance - 2.0;
            }
        }
        public void AddMoney(double amount)
        {
            // write code here
            if (amount >= 0){
            


                if (this.balance + amount < 150 && this.balance >= 0)
                {
                    this.balance += amount;
                }
                else if (this.balance + amount > 150)
                {
                    this.balance = 150;
                }
                

            } 
                     
                 
            

        }


    }

}