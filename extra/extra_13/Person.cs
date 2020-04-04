using System;

namespace extra_13
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
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
            return this.name + ", age " + this.age;
        }
    }
}