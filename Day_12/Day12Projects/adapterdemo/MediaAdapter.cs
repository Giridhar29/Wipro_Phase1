namespace adapterdemo;

// Step 4: Create the Adapter Class
public class MediaAdapter : IMediaPlayer
{
    private VLCPlayer _vlcPlayer;
    private MP4Player _mp4Player;

    public void Play(string audioType, string fileName)
    {
        if (audioType.ToLower() == "vlc")
        {
            _vlcPlayer = new VLCPlayer();
            _vlcPlayer.PlayVLC(fileName);
        }
        else if (audioType.ToLower() == "mp4")
        {
            _mp4Player = new MP4Player();
            _mp4Player.PlayMP4(fileName);
        }
    }
}
