using System;
using AVFoundation;
using Foundation;
using XamarinAdvanced.Dependency;
using XamarinAdvanced.iOS.Dependency;

[assembly: Xamarin.Forms.Dependency(typeof(AudioManager))]
//Xamarin.Forms.DependencyService.Register<IAudioManager, AudioManager>();
namespace XamarinAdvanced.iOS.Dependency
{
    public class AudioManager : IAudioManager
    {
        private AVAudioPlayer _mAudioPlayer;

        public AudioManager()
        {
        }

        public void PlayAudio(string file)
        {
            if(_mAudioPlayer != null)
            {
                _mAudioPlayer.Stop();
                _mAudioPlayer.Dispose();
                _mAudioPlayer = null;
            }
            var soundFile = NSBundle.MainBundle.PathForResource(file, null);
            var url = NSUrl.FromFilename(soundFile);
            _mAudioPlayer = AVAudioPlayer.FromUrl(url);
            _mAudioPlayer.Play();
        }
    }
}
