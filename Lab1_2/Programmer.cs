using System;

namespace Lab1_2
{
    public class Programmer : Worker
    {
        public string Position { get; set; }

        public Programmer(string position)
        {
            Position = position;
        }

        public Programmer(int salary, string position) : base(salary)
        {
            Position = position;
        }

        public Programmer(int age, string name, string sex, int salary, string position) : base(age, name, sex, salary)
        {
            Position = position;
        }

        public Programmer(int age, string name, string sex, int height, int weight, string eyeColor, int salary, string position) : base(age, name, sex, height, weight, eyeColor, salary)
        {
            Position = position;
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is coding");
        }

        public void Learn(string language)
        {
            Console.WriteLine($"{Name} is learning how to code using {language}");
        }
    }
}