using System;

namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Song[] songs = new Song[n];

            for (int i = 0; i < n; i++)
            {
                string[] songInfo = Console.ReadLine().Split('_');
                string typeList = songInfo[0];
                string name = songInfo[1];
                string time = songInfo[2];
                songs[i] = new Song(typeList, name, time);
            }

            string filter = Console.ReadLine();

            if (filter == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.ToString());
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == filter)
                    {
                        Console.WriteLine(song.ToString());
                    }
                }
            }
        }

        private class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
            public Song(string typeList, string name, string time)
            {
                TypeList = typeList;
                Name = name;
                Time = time;
            }
            public string ToString()
            {
                return Name;
            }
        }
    }
}
