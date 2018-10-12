using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Artist
    {
       public string name;
        public ArrayList songs = new ArrayList();
        public Artist()
        {
            this.name = "None";
        }
        public Artist(String name, ArrayList songs)
        {
            this.name = name;
            this.songs = songs;
        }
        public Artist(string name)
        {
            this.name = name;
        }
    }
}
