using System;
using System.Collections.Generic;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songPropetries = Console.ReadLine().Split('_');
                Song song = new Song(songPropetries[0], songPropetries[1], songPropetries[2]);

                songs.Add(song);
            }
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }

        class Song
        {
            public Song(String typeList, string name, string time)
            {
                this.TypeList = typeList;
                this.Name = name;
                this.Time = time;
            }

            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
