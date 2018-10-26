using System;

using System.Collections.Generic;



namespace AudioPlayer.domain

{

    class Program

    {

        static void Main(string[] args)

        {

            //VolumeExample();

            //AddOverloadingExample();

            //SortAndShuffleExample();



            ClassicUsagePlayerExample();



            Console.ReadLine();



        }



        private static void ClassicUsagePlayerExample()

        {

            var player = new AudioPlayer();



            Song currentPlayingSong = null;

            Song[] songs = null;

            Album album = null;

            Artist artist = null;



            CreatePlayerItems(out songs, out artist, out album);



            player.Add(songs);

            player.Play();

        }



        private static void AddOverloadingExample()

        {

            Song currentPlayingSong = null;

            Song[] songs = null;

            Album album = null;

            Artist artist = null;



            var player = new AudioPlayer();

            CreatePlayerItems(out songs, out artist, out album);



            Console.WriteLine("-- Playing Album --");

            player.Add(album);

            Console.WriteLine(player.Play());



            Console.WriteLine("-- Playing Artist --");

            player.Add(artist);

            Console.WriteLine(player.Play());

        }



        private static void SortAndShuffleExample()

        {

            var player = new AudioPlayer();



            Song currentPlayingSong = null;

            Song[] songs = null;

            Album album = null;

            Artist artist = null;



            CreatePlayerItems(out songs, out artist, out album);

            player.Add(songs);



            Console.WriteLine("-- Playing Songs --");

            System.Threading.Thread.Sleep(3000);

            player.Play();



            Console.WriteLine("-- Suffle Songs --");

            System.Threading.Thread.Sleep(3000);

            player.Shuffle();

            player.Play();



            Console.WriteLine("-- Sort Songs --");

            System.Threading.Thread.Sleep(3000);

            player.SortByTitle();

            player.Play();

        }



        private static void VolumeExample()

        {

            var player = new AudioPlayer();



            Console.WriteLine(player.volume);






            player.volumeChange(int.Parse(Console.ReadLine()));



            Console.WriteLine(player.volume);

        }



        private static void CreatePlayerItems(out Song[] songs, out Artist artist, out Album album)

        {

            artist = new Artist() { Name = "Maximum the hormone", Songs = new List<Song>(), Albums = new Album[1] };

            album = new Album() { Artist = artist, name = "MTHbest", Songs = new List<Song>() };

            songs = CreateSongs(artist, album);



            artist.Albums[0] = album;



            artist.Songs = new List<Song>() { songs[0], songs[2], songs[4] };

            album.Songs = new List<Song>() { songs[1], songs[3], songs[4] };



            songs[0].like = false;
            songs[3].like = true;
            songs[4].like = true;
            songs[1].like = false;        
            songs[2].like = true;
        }



        private static Song[] CreateSongs(Artist artist, Album album)

        {

            return new Song[] {

                new Song()

                {

                    name = "Yushi Fukishu",

                    duration = 300,

                    lyrics = @"chu ni...chu ni ka / ryou no nou / mou shu ni de korokoro komikku mo-do",

                    albumForCurrentSong = album,

                    artist = artist,

                    Genr = genre.pop /*0001*/ | genre.rock /*0010*/ //0011

                },

                new Song()

                {

                    name = "I'm a rock",

                    duration = 300,

                    lyrics = @"I'm a rock, i'm an island... ",

                    albumForCurrentSong = album,

                    artist = artist,

                    Genr = genre.pop /*0001*/ | genre.rock /*0010*/ //0011

                },
 new Song()

                {

                    name = "Help",

                    duration = 300,

                    lyrics = @"I wake up in the morning synking halfway to the bottom....",

                    albumForCurrentSong = album,

                    artist = artist,

                    Genr = genre.pop /*0001*/ | genre.rock /*0010*/ //0011

                },
 new Song()

                {

                    name = "Black Case",

                    duration = 300,

                    lyrics = @"He did'n know. He did'n say. I should have gone.....",

                    albumForCurrentSong = album,

                    artist = artist,

                    Genr = genre.pop /*0001*/ | genre.rock /*0010*/ //0011

                },
 new Song()

                {

                    name = "Suffer little children",

                    duration = 300,

                    lyrics = @"Over the more, take me to the moon.....",

                    albumForCurrentSong = album,

                    artist = artist,

                    Genr = genre.pop /*0001*/ | genre.rock /*0010*/ //0011

                },

            };

        }

    }

}