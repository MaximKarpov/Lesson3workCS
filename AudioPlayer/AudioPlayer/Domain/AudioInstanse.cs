using System;
using System.Collections.Generic;
using System.Linq;
using AudioPlayer.Extension;


namespace AudioPlayer
{
    public class AudioPlayer
    {
        public static int PlayersCount;
        public bool Locked { get; set; }

        public bool isPlaying { get; set; }

        public Song playingSong { get; set; }

        private int _volume;

        public AudioPlayer()
        {
            PlayersCount++;
        }

        public List<Song> Songs { get; set; }
        public PlayList playList;

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

        public void volumeChange(int step)
        {
            volume += step;
        }

        public void Lock()
        {
            Locked = true;
        }

        public void Unlock()
        {
            Locked = false;
        }

        public void Add(params Song[] songes)

        {

            this.Songs = songes.ToList();

        }
        public void Add(PlayList playlist)

        {

            Songs = playlist.songs;

        }

        public void Add(Album album)

        {

            Songs = album.Songs;

        }
        public void Add(Artist artist)

        {

            Songs = artist.Songs;

        }



        public bool Play(bool loop = false)

        {

            playingSong = this.playingSong = this.playingSong ?? Songs[0];



            if (!Locked)

            {

                isPlaying = true;

            }



            if (isPlaying)

            {

                int cycles = loop ? 5 : 1;

                for (int i = 0; i < cycles; i++)

                {

                    foreach (var song in Songs)

                    {

                        this.playingSong = song;



                        Console.Clear();



                        ListSongs();

                        Console.WriteLine(this.playingSong.name + ": " + this.playingSong.name);



                        System.Threading.Thread.Sleep(2000);

                    }

                }

            }



            return isPlaying;

        }

        public void Filter(genre genre)

        {

            var filteredSongs = new List<Song>();



            foreach (Song song in this.Songs)

            {

                if ((song.Genr & genre) == genre)

                {

                    filteredSongs.Add(song);

                }

            }



            this.Songs = filteredSongs;

        }


        private void ListSongs()

        {

            foreach (var song in Songs)

            {

                var data = GetSongData(song);

                var songInfo = $"{data.title} - {data.duration.min}:{data.duration.sec}";

                if (data.isPlayingNow)

                {

                    songInfo = $"***{songInfo}***";

                }



                if (data.like.HasValue)

                {

                    if (data.like.Value)

                    {

                        Console.BackgroundColor = ConsoleColor.DarkGreen;

                        Console.WriteLine(songInfo);

                        Console.ResetColor();

                    }

                    else

                    {

                        Console.BackgroundColor = ConsoleColor.Magenta;

                        Console.WriteLine(songInfo);

                        Console.ResetColor();

                    }

                }

                else

                {

                    Console.WriteLine(songInfo);

                }

            }

        }

        private (string title, (int min, int sec) duration, bool isPlayingNow, bool? like) GetSongData(Song song)

        {

            var title = song.name;

            var isPlayingNow = song == playingSong;

            var min = song.duration / 60;

            var sec = song.duration % 60;

            var (t, d, a) = song;

            return (title, (min, sec), isPlayingNow, song.like);

        }


        /*
                private dynamic GetSongData(Song song)

                {

                    var title = song.Title;

                    var isPlayingNow = song == PlayingSong;

                    var min = song.Duration / 60;

                    var sec = song.Duration % 60;



                    //return (title, (min, sec), isPlayingNow);



                    return new

                    {

                        title,

                        duration = new

                        {

                            min,

                            sec

                        },

                        isPlayingNow                

                    };

                }*/



        public bool Stop()

        {

         



            if (Locked == false)

            {

                isPlaying = false;

            }



            return isPlaying;

        }




        public void Shuffle()
        {

            Songs = Songs.Suffle();
        }



        public void SortByTitle()

        {

            List<string> names = new List<string>();

            List<Song> sorted = new List<Song>();



            foreach (var song in Songs)

            {

                names.Add(song.name);

            }



            names.Sort();



            foreach (var name in names)

            {

                foreach (var song in Songs)

                {

                    if (song.name == name)

                    {

                        sorted.Add(song);

                        continue;

                    }

                }

            }



            Songs = sorted;

        }
    }

}

