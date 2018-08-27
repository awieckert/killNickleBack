using System;
using System.Collections.Generic;

namespace killNickleBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<(string, string)> goodSongs = new List<(string, string)>();

            HashSet<(string, string)> allSongs = new HashSet<(string, string)>();
            allSongs.Add(("Jimi", "Purple Haze"));
            allSongs.Add(("Nickleback", "Not Important"));
            allSongs.Add(("Nickleback", "Does it matter?"));
            allSongs.Add(("Creed", "Should probably get rid of this one too..."));
            allSongs.Add(("Boston", "More than a feeling"));

            foreach ((string artist, string name) song in allSongs)
            {
              if (song.artist != "Nickleback") {
                goodSongs.Add(song);
              }
            }

            Console.WriteLine("List of good songs! aka no Nickleback!: ");

            foreach ((string artist, string name) song in goodSongs)
            {
                Console.WriteLine($"\"{song.name}\" by {song.artist}");
            }
        }
    }
}
