namespace TaskMusicPlaylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist();
            Song song = new("aaa", "bbb", new TimeSpan(0, 1, 34), MusicGenre.Pop);
            Song song1 = new("ddd", "fff", new TimeSpan(0,7,9), MusicGenre.Pop);
            Song song2 = new("ooo", "uuu", new TimeSpan(0, 5, 7), MusicGenre.Jazz);
            playlist.AddSong(song);
            playlist.AddSong(song1);
            playlist.AddSong(song2);
            foreach(var s in playlist.GetAllSongsByGenre(MusicGenre.Pop))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            playlist.DisplayAllSongs();
        }
    }
}
