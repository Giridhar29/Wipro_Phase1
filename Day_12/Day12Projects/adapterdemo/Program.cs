namespace adapterdemo;

class Program
{
    static void Main(string[] args)
    {
        IMediaPlayer mediaPlayer = new AudioPlayer();
        
        // Playing various formats
        mediaPlayer.Play("mp3", "song.mp3");
        mediaPlayer.Play("mp4", "video.mp4");
        mediaPlayer.Play("vlc", "movie.vlc");
        mediaPlayer.Play("avi", "unsupported.avi");

        Console.ReadLine();
    }
}
