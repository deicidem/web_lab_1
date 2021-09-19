using System;

namespace Lab1_2
{
    public class Dog : Animal
    {
        public string Breed{ get; set; }

        public Dog(string breed)
        {
            Breed = breed;
        }

        public Dog(int age, string name, string breed) : base(age, name)
        {
            Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} doing Woof-Woof");
        }

        public override void Eat(string food)
        {
            Console.WriteLine(food != "meat" ? $"{Name} doesn't eat {food}, it wants meat" : $"{Name} is eating {food}");
        }

        public override void Drink(string liquid)
        {
            Console.WriteLine(liquid != "water" ? $"{Name} doesn't drink {liquid}, it wants water" : $"{Name} is drinking {liquid}");
        }
    }
}