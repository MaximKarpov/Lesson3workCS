using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
   public class Song
    {
       public Album albumForCurrentSong;
       public string name;
        public string artist;
        public int duration;
        public string lyrics;
    
        public Song()
        {
            this.name = "Unknown";
            this.artist = "Unknown artist";
            this.duration = 0;
            this.lyrics = "No lyrics found";
        }
        public Song(string name, string lyrics, int duration)
        {
            this.name = name;
            this.lyrics = lyrics;
            this.duration = duration;

        }

    }
}
