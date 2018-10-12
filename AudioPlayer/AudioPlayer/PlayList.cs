using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
   public class PlayList
    {
        public string name;
        public List<Song> songs;
        public PlayList(string name, Song[] songs)
        {
            foreach (Song newSong in songs)
            {
                this.songs.Add(newSong);
            }
            this.name = name;
        }
        public void add(params Song[] songs)
        {
            foreach (Song newSong in songs)
            {
                this.songs.Add(newSong);
            }
        }
    }
}
