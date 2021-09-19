using System;

namespace Lab1_2
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
            Console.WriteLine();
            var worker = new Worker(20, "Petr Petrov", "male", 10000);
            worker.Eat("pizza");
            worker.Work();
            Console.WriteLine(worker.Salary);
            Console.WriteLine();
            var programmer = new Programmer(23, "Thomas Black", "male", 100000, "Middle front-end developer");
            programmer.Work();
            programmer.Learn("C#");
            Console.WriteLine();
            var dog = new Dog(2, "Bobik", "pug");
            dog.Eat("grass");
            dog.Bark();
            dog.Eat("meat");

        }
    }
}