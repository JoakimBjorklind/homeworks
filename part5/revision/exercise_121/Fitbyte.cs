using System;

namespace exercise_121
{
    public class Fitbyte
    {
        private int age;
        private int restingHeartRate;

        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }
        public double MaximumHeartRate()
        {
            return 206.3 - (0.711 * this.age);
        }
        public double TargetHeartRate(double percentageOfMaximum)
        {
            return (MaximumHeartRate() - restingHeartRate) * percentageOfMaximum + restingHeartRate;
            
        }
    }

}