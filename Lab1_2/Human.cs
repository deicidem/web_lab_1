using System;

namespace Lab1_2
{
    public class Human : Animal, IDisposable
    {
        protected string Sex { get; set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }
        private readonly string eyeColor;
        private static int _walkingSpeed = 1;
        
        public Human()
        {
            this.Sex = "male";
            this.Height = 180;
            this.Weight = 70;
            this.eyeColor = "brown";
        }

        public Human(int age, string name, string sex): base(age, name)
        {
            this.Sex = sex;
            this.Height = 180;
            this.Weight = 70;
            this.eyeColor = "brown";
        }

        public Human(int age, string name, string sex, int height, int weight, string eyeColor): base(age, name)
        {
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

        public override void Eat(string food)
        {
            Console.WriteLine($"{Name} ate {food}");
        }

        public override void Drink(string liquid)
        {
            Console.WriteLine($"{Name} drank {liquid}");
        }

        public override void Sleep(int hours)
        {
            Console.WriteLine($"{Name} slept for {hours} hours");
        }

        public void Walk(int distance)
        {
            Console.WriteLine($"{Name} walked {distance} meters in {distance / _walkingSpeed} seconds");
        }
        
        public void Walk(string place)
        {
            Console.WriteLine($"{Name} walked to {place}");
        }

        public static void SetWalkingSpeed(int speed)
        {
            _walkingSpeed = speed > 0 ? speed : 1;
        }
    }
}