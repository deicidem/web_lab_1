using System;

namespace Lab1_1
{
    public class Human : IDisposable
    {   
        public string Name { get; set; }
        private int age;
        public int Age
        {
            get => age;
            set => age = value >= 0 ? value : 0;
        }
        
        protected string Sex { get; set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }
        private static int walkingSpeed = 1;
        private readonly string eyeColor;
        
        public Human()
        {
            this.age = 0;
            this.Name = "No name";
            this.Sex = "male";
            this.Height = 180;
            this.Weight = 70;
            this.eyeColor = "brown";
        }

        public Human(int age, string name, string sex)
        {
            this.age = age;
            this.Name = name;
            this.Sex = sex;
            this.Height = 180;
            this.Weight = 70;
            this.eyeColor = "brown";
        }

        public Human(int age, string name, string sex, int height, int weight, string eyeColor)
        {
            this.age = age;
            this.Name = name;
            this.Sex = sex;
            this.Height = height;
            this.Weight = weight;
            this.eyeColor = eyeColor;
        }

        ~Human()
        {
            Console.WriteLine("died :(");
            Console.ReadKey();
        }

        public void Dispose()
        {
            Console.WriteLine($"{Name} died :(");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} ate {food}");
        }

        public void Drink(string liquid)
        {
            Console.WriteLine($"{Name} drank {liquid}");
        }

        public void Sleep(int hours)
        {
            Console.WriteLine($"{Name} slept for {hours} hours");
        }

        public void Walk(int distance)
        {
            Console.WriteLine($"{Name} walked {distance} meters in {distance / walkingSpeed} seconds");
        }
        
        public void Walk(string place)
        {
            Console.WriteLine($"{Name} walked to {place}");
        }

        public static void SetWalkingSpeed(int speed)
        {
            walkingSpeed = speed > 0 ? speed : 1;
        }
    }
}