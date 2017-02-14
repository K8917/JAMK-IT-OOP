using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<Song> Songs;
        public CD()
        {
            Songs = new List<Song>();
        }
        public CD(string name, string artist)
            : this()
        {
            Name = name;
            Artist = artist;
        }
        public void PrintInfo()
        {
            Console.WriteLine("- Name: " + Name);
            Console.WriteLine("- Artist: " + Artist);
            Console.WriteLine("- Songs: ");
            foreach (Song Song in Songs)
            {
                Console.WriteLine(Song.ToString());
            }
        }
    }
    class Song : CD
    {
        public string Runtime { get; set; }
        public Song() { }
        public Song(string name, string runtime)
        {
            Name = name;
            Runtime = runtime;
        }
        public override string ToString()
        {
            return "  - " + Name + ", " + Runtime;
        }
    }
}
