namespace P06_Animals
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        private string Name
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }

        private int Age
        {
            set
            {
                if (string.IsNullOrEmpty(value.ToString()) || value <= 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }

        private string Gender
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return string.Format("{0}{1}{2} {3} {4}{1}{5}",
                this.GetType().Name, // 0
                Environment.NewLine, // 1
                this.name, // 2
                this.age,  // 3
                this.gender, // 4
                this.ProduceSound()); // 5
        }
    }
}
