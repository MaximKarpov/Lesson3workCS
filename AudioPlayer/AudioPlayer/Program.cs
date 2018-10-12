using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AudioPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Song oneSong;
            Song song1 = new Song("one", "is it getting better....", 5);
            Song song2 = new Song("Ting", "Da ting goes skrrra and kakakaka", 3);
            Song song3 = new Song("Waterfal", "she is the waterfall", 5);
            Song song4 = new Song("help", "i wake up in the morning sinking halfway.....", 4);
            Song song5 = new Song("Itergallactic", "Inter gallactic planitary planitary intergallactic", 5);
            ArrayList songlist = new ArrayList();
            songlist.Add(song1);
            songlist.Add(song2);
            songlist.Add(song3);
            songlist.Add(song4);
            songlist.Add(song5);


            Artist Author = new Artist("SomeName", songlist);
            Album SomeAlbum = new Album("Get this or die", songlist);

           
            AudioPlayer player = new AudioPlayer();
            Song Rei = new Song();
            player.volume = 50;
            Console.WriteLine(player.volume);
           
            player.volumePlus(); player.volumePlus(); player.volumePlus(); player.volumePlus();
            Console.WriteLine(player.volume);
            player.Add(song2);
            player.Add(Author);
  
            player.Play(out oneSong);
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(player.playingSong.lyrics);
            }
            //это изменение!!!!!!!
            Console.ReadKey();
        }
    }
}
