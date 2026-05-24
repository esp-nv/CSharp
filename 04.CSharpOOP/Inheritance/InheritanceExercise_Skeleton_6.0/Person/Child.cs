using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Child : Person
    {
        private const int CHILD_MAX_AGE = 15;

        public Child(string name, int age) : base(name, age)
        {
        }

        // от тук нататък създава нова логика, но може да използвам и старата която ми идва от класа Person благодарение на virtual

        // ако напиша така public new int Age => това означава, че скрива някакво друго property и сегашното ще се презапише и няма да го интересува за базовия Age
        public override int Age
        {
            get
            {
                // взима от базовия клас Age
                return base.Age;
            }
            protected set
            {
                if (value <= CHILD_MAX_AGE)
                {
                    base.Age = value;
                }
            }
        }
    }
}
