using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.SecondExameple
{
    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;


        public void play(String audioType, String fileName)
        {

            //inbuilt support to play mp3 music files
            if (audioType.Equals("mp3"))
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }

            //mediaAdapter is providing support to play other file formats
            else if (audioType.Equals("vlc") || audioType.Equals("mp4"))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.play(audioType, fileName);
            }

            else {
                Console.WriteLine("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}
