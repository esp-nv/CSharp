using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    /*
     * не е хубаво да имам просто герой, трябва да имам конкретната имплементация на героя
     * сбсракните са такивакласове които държат функционалност, държат данни,
     * но не искам тази функционалност да бъде използвана в този чист вид, искаме да бъде използвана от някого друг
    */
    public abstract class Hero
    {
        private const int HERO_MIN_LEVEL = 0;

        private string username;
        private int level;

        protected Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;

        }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                //всичко дори и една буква би върнало false
                //String => така  викам през класа, а така string => ключова дума, и в двата случая 
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Username cannot be null or whitespase!");
                }

                this.username = value;
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            private set
            {
                if (value < HERO_MIN_LEVEL)
                {
                    throw new ArgumentException("Level cannot be negative number!");
                }

                this.level = value;
            }
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
