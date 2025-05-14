using System;

public interface IMusicPlayer
{
    void Play(string song);
    void Pause();
    void Stop();
}
public class Spotify:IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine($"Playing \"{song}\" on Spotify");
    }
    public void Pause()
    {
        Console.WriteLine("Spotify playback paused");
    }
    public void Stop()
    {
        Console.WriteLine("Spotify playback stopped");
    }
}
public class AppleMusic : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine($"Playing \"{song}\" on Apple Music");
    }
    public void Pause()
    {
        Console.WriteLine("Apple Music playback paused");
    }
    public void Stop()
    {
        Console.WriteLine("Apple Music playback stopped");
    }
}
class program
{
    static void Main()
    {
        IMusicPlayer musicPlayer;
        musicPlayer=new Spotify();
        musicPlayer.Play("Taki Taki");
        musicPlayer.Pause();
        musicPlayer.Stop();

        Console.WriteLine();
        
        musicPlayer=new AppleMusic();
        musicPlayer.Play("Imagine");
        musicPlayer.Pause();
        musicPlayer.Stop();
    }
}