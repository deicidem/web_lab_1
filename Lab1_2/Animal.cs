using System;

namespace Lab1_2
{
    public abstract class Animal
    {
        protected string Name { get; set; }
        private int age;
        protected int Age
        {
            get => age;
            set => age = value >= 0 ? value : 0;
        }

        protected Animal()
        {
            age = 0;
            Name = "No name";
        }

        protected Animal(int age, string name)
        {
            this.age = age;
            Name = name;
        }

        public abstract void Eat(string food);
        public abstract void Drink(string liquid);

        public virtual void Sleep(int hours)
        {
            Console.WriteLine($"{Name} slept {hours} hours");
        }
    }
}