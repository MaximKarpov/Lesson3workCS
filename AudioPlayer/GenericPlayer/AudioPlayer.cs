using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AudioPlayer
{
    public class AudioPlayer
    {

        public bool Locked;
        public bool isPlaying;
        public PlayingItem playingItem;
        private int _volume;
      public ArrayList Items = new ArrayList();
       // public PlayList playList;
        int numsongs=0;



       public int volume
        {
            get { return _volume; }
            set
            {
                if (value > 100) _volume = 100;


                else if (value < 0) _volume = 0;

                else _volume = value;

            }
        }
           public void volumePlus()
                {
                   this.volume++; 
                }
             
               public void volumeMinus()
                {
                   this.volume--;
                }

        public void Lock()
        {
            Locked = true;
        }
        public void Unlock()
        {
            Locked = false;
        }

        public void Add(PlayingItem newSong)
        {
        this.songs.Add(newSong);
        
        }
        public void Add(Artist someArtist)
        {
            for (int i = 0; i < someArtist.songs.Count; i++) {
                songs.Add(someArtist.songs[i]);
              
            }
        }
         public void Add(PlayList newPlaylist)
        {
            for (int i = 0; i < newPlaylist.songs.Count; i++)
            {
               this.songs.Add(newPlaylist.songs[i]);
             
            }
        }
        




        public bool Play(out Song nowPlaying)
        {
            if (!Locked)
            {
                isPlaying = true;
                if (playingSong == null && songs != null)
                {
                    playingSong = (Song)songs[0];
                }
            }

            nowPlaying = this.playingSong;
            if (nowPlaying != null)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(nowPlaying.lyrics);
                }
            }
            return isPlaying;
        }




        public bool Stop(out Song nowPlayed)
        {

            nowPlayed = this.playingSong;

            if (!Locked)
            {
                isPlaying = false;
            }
            return isPlaying;
        }





            }
        }
    

