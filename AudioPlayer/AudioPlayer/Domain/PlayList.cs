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
        public void Add(params Song[] songes)

        {

            songs = songes.ToList<Song>();

        }
    }
}
