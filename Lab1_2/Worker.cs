using System;

namespace Lab1_2
{
    public class Worker : Human
    {
        public int Salary { get; set; }

        public Worker() : base()
        {
            this.Salary = 0;
        }

        public Worker(int salary)
        {
            Salary = salary;
        }

        public Worker(int age, string name, string sex, int salary) : base(age, name, sex)
        {
            Salary = salary;
        }

        public Worker(int age, string name, string sex, int height, int weight, string eyeColor, int salary) : base(age, name, sex, height, weight, eyeColor)
        {
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{this.Name} is working");
        }
    }
}