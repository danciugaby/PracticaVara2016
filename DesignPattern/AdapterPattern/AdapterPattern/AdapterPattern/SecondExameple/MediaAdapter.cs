using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.SecondExameple
{
    public class MediaAdapter : MediaPlayer
    {

        AdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(String audioType)
        {

            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer = new VlcPlayer();

            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }

        public void play(String audioType, String fileName)
        {
            advancedMusicPlayer.playMp4(fileName);
            advancedMusicPlayer.playVlc(fileName);
            //if (audioType.Equals("vlc"))
            //{
            //    advancedMusicPlayer.playVlc(fileName);
            //}
            //else if (audioType.Equals("mp4"))
            //{
            //    advancedMusicPlayer.playMp4(fileName);
            //}
        }

    }
}
