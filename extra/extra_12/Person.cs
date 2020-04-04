using System;

namespace extra_12
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string initialName)
        {
            this.name = initialName;
            this.age = 0;
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