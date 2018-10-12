using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Album
    {
        public string name;
        public ArrayList songs;
           public Album(string name, ArrayList songs)
        {
            this.name = name;
            this.songs = songs;
        } 
    }
}
