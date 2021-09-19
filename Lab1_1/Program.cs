using System;

namespace Lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human(19, "Ivan Ivanov", "male", 172, 67, "blue");
            human.Eat("burger");
            human.Drink("Coca-Cola");
            human.Sleep(8);
            human.Walk(10);
            Human.SetWalkingSpeed(2);
            human.Walk(10);
            human.Dispose();
        }
    }
}