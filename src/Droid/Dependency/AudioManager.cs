using System;
using Android.Media;
using XamarinAdvanced.Dependency;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinAdvanced.Droid.Dependency.AudioManager))]
namespace XamarinAdvanced.Droid.Dependency
{
    public class AudioManager : IAudioManager
    {
        MediaPlayer player;

        public AudioManager()
        {
        }

        public void PlayAudio(string file)
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
            var afd = Xamarin.Forms.Forms.Context.Assets.OpenFd(file);
            player = new MediaPlayer();
            player.SetDataSource(afd.FileDescriptor, afd.StartOffset, afd.Length);
            player.Prepare();
            player.Start();
        }
    }
}
