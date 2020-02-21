using System;

namespace exercise_124
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
        public void GrowOlder(int years)
        {
            this.age += years;
        }



        public override string ToString()
        {
            return this.name + ", age " + this.age + " years";
        }


    }
}