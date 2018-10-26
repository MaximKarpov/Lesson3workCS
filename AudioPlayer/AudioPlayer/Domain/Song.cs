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

       public string name {get; set; }

        public Artist artist { get; set; }

        public int duration { get; set; }

        public string lyrics { get; set; }

        public genre Genr;

        public bool? like { get; set; }

        public Song()
        {
            this.name = "Unknown";
            this.artist = artist;
            this.duration = 0;
            this.lyrics = "No lyrics found";
        }

        public Song(string name, string lyrics)
        {
            this.name = name;
            this.lyrics = lyrics;
            this.duration = duration;

        }
        public void LikeSong()

        {

            like = true;

        }



        public void DislikeSong()

        {

            like = false;

        }
        public void Deconstruct(out string title, out int duration, out string artist)
        {
            title = this.name;
            duration = this.duration;
            artist = this.artist?.Name;
        }
    }
}
