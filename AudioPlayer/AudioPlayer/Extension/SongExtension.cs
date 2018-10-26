using System.Collections.Generic;



namespace AudioPlayer.Extension
{
    public static class SongExtension
    {
        public static List<Song> Suffle(this List<Song> Songs)
            {

            List<Song> suffledSongs = new List<Song>();

            int step = 3;

            for (int i = 0; i < step; i++)

            {

                int index = i;



                while (index < Songs.Count)

                {

                    suffledSongs.Add(Songs[index]);

                    index += step;

                }

            }



            Songs = suffledSongs;
            return Songs;
        }
    }
}
