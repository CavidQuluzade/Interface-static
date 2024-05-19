using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMusicPlaylist
{
    public class Playlist
    {
        private Song[] songs;
        private int count;
        public Playlist()
        {
            songs = new Song[1];
            count = 0;
        }
        public void AddSong(Song song)
        {
            if (count == songs.Length)
            {
                Array.Resize(ref songs, songs.Length + 1);
            }
            songs[count] = song;
            count++;
        }
        public Song[] GetAllSongsByGenre(MusicGenre genre)
        {
            Song[] genreSongs = new Song[count];
            int genreCount = 0;
            for (int i = 0; i < count; i++)
            {
                if (songs[i].Genre == genre)
                {
                    genreSongs[genreCount] = songs[i];
                    genreCount++;
                }
            }
            Array.Resize(ref genreSongs, genreCount);
            return genreSongs;
        }
        public void DisplayAllSongs()
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }
}
