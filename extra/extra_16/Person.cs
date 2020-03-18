using System;

namespace extra_16
{
    public class Person
    {
        private string name;
        private int age;
        private int weight;
        private int height;


        public Person(string name, int age, int height, int weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.weight = 0;
            this.height = 0;
        }
        public Person(string name)
        {
            this.name = name;
            this.age = 0;
            this.weight = 0;
            this.height = 0;
        }
        
        public void GrowOlder(int howMuch)
        {
           if(this.age >= 0)
           {
           this.age += howMuch;
           }
        }
        public override string ToString() 
        {
            return this.name + ", age " + this.age + ", height " + this.height + ", weight " + this.weight;
        }
    }
}