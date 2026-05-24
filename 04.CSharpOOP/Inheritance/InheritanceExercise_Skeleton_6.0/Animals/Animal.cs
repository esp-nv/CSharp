using System;
using System.Text;


namespace Animals
{
    public abstract class Animal
    {
        private const string ERROR_MESSAGE = "Invalid input!";

        private const int ANIMAL_MIN_AGE = 0;

        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                //всичко дори и една буква би върнало false
                //String => така  викам през класа, а така string => ключова дума, и в двата случая 
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ERROR_MESSAGE);
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            //protected => да може да се вижда от наследените класове
            private set
            {
                if (value < ANIMAL_MIN_AGE)
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }

                this.gender = value;
            }
        }

        //като не знае какво да върне -- всеки който го наследи трябва да каже какво да прави, този метод е без тяло
        //това го има само в абстрактен клас
        // метод без тяло, ние не знаем какво прави за абстракния, базовия, затова го оставяме без тяло,
        // но всеки който наследява базовия клас е длъжен да даде тяло на този метод
        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            //GetType() => винаги ще извиква от конкретната инстанция от която работи
            //GetType().Name =>връща името на класа
            //GetType().FullName=>връща името на namespase и името на класа
            sb
                .AppendLine($"{this.GetType().Name}")
                .AppendLine($"{this.Name} {this.Age} {this.Gender}")
                .AppendLine($"{this.ProduceSound()}");

            return sb.ToString().TrimEnd();
        }

    }
}
