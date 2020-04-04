using System;

namespace exercise_104
{
    public class Multiplier
    {
        //instance variable called originalnumber
        private int originalNumber;
        // constructor, takes integer as a parameter
        // stores it into the instance variable
        public Multiplier(int originalNumber)
        {
            // storing done here
           this.originalNumber = originalNumber;
        }
        //Methos "multiplier" multiplies with a number
        //stores and returns the new value
        public int Multiply(int multiplier)
        {
            return this.originalNumber = this.originalNumber * multiplier;  
          
        }
    }
}