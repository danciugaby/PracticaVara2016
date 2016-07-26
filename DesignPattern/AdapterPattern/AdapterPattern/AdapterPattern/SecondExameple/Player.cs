using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.SecondExameple
{
    public class VlcPlayer : AdvancedMediaPlayer
    {

        public void playVlc(String fileName)
        {
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }


        public void playMp4(String fileName)
        {
            //do nothing
        }
    }


    public class Mp4Player : AdvancedMediaPlayer
    {

        public void playVlc(String fileName)
        {
            //do nothing
        }


        public void playMp4(String fileName)
        {
            Console.WriteLine("Playing mp4 file. Name: " + fileName);
        }
    }
}

