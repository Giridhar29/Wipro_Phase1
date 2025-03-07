namespace adapterdemo;

// Step 2: Implement Existing Functionality (Supports MP3 Only)
public class AudioPlayer : IMediaPlayer
{
    private MediaAdapter _mediaAdapter;
  
    public void Play(string audioType, string fileName)
    {
        if (audioType.ToLower() == "mp3")
        {
            Console.WriteLine($"Playing MP3 file: {fileName}");
        }
        else if (audioType.ToLower() == "vlc" || audioType.ToLower() == "mp4")
        {
            _mediaAdapter = new MediaAdapter();
            _mediaAdapter.Play(audioType, fileName);
        }
        else
        {
            Console.WriteLine($"Invalid media: {audioType} format not supported.");
        }
    }
}
