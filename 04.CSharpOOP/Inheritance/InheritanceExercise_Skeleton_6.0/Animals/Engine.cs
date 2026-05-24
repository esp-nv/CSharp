using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Engine
    {
        private const string END_OF_INPUT_COMMAND = "Beast!";
        private readonly List<Animal> animals;
        public Engine()
        {
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string type;
            while ((type = Console.ReadLine()) != END_OF_INPUT_COMMAND)
            {
                string[] animalArg = Console.ReadLine().Split().ToArray();

                Animal animal;

                try
                {
                   animal = GetAnimal(type, animalArg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                this.animals.Add(animal);
            }

            PrintOutput();
        }

        private void PrintOutput()
        {
            foreach (Animal animal in this.animals)
            {
                Console.WriteLine(animal);

            }
        }

        private Animal GetAnimal(string type, string[] animalArg)
        {

            string name = animalArg[0];
            int age = int.Parse(animalArg[1]);
            string gender = GetGender(animalArg);

            Animal animal = null;


            if (type == "Dog")
            {
                animal = new Dog(name, age, gender);
            }
            else if (type == "Cat")
            {
                animal = new Cat(name, age, gender);
            }
            else if (type == "Frog")
            {
                animal = new Frog(name, age, gender);
            }
            else if (type == "Ktten")
            {
                animal = new Kitten(name, age);
            }
            else if (type == "Tomcat")
            {
                animal = new Tomcat(name, age);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }
            return animal;
        }

        private string GetGender(string[] animalArg)
        {
            string gender = null;

            if (animalArg.Length >= 3)
            {
                gender = animalArg[2];
            }

            return gender;
        }
    }
}
