using System;

namespace exercise_124
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Implement your program here!
            Person joan = new Person("Joan Ball", 22);
            Console.WriteLine(joan);

            Person ball = joan;
            ball.GrowOlder(1);
            ball.GrowOlder(1);

            Console.WriteLine(joan);

            joan = new Person("Joan B.", 22);
            Console.WriteLine(joan);

            ball = null;
            Console.WriteLine(ball);
            ball.GrowOlder(1);





        }
    }
}
