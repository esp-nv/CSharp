using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    //  public abstract class Person това е абстрактен клас, които не могат да се инициализират 
    //тоима някаква функционалност ще я предаде на всички останали, но не искам да може да има само Person
    public class Person
    {
        private const int PERSON_MIN_AGE = 0;

        //field
        private string name;
        private int age;

        //constructor
        public Person(string name, int age)
        {
            //ако гo напиша this.age = age => така ще изпусна валидацията на age
            this.Name = name;
            this.Age = age;
        }

        //property
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                // ако го напиша така this.Name  ще ми даде грешка stack over fllow - все едно правя рекурсия и така препълвам стека
                this.name = value;
            }
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }
            //protected => да може да се вижда от наследените класове
            protected set
            {
                if (value >= PERSON_MIN_AGE)
                {
                    this.age = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("{0} -> ",
                                 this.GetType().Name));
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();


        }
    }
}
