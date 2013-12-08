using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beat_Analyzer
{
    class playSound
    {
        public string sound;

        public playSound(string s)
        {
            sound = s;
        }

        public void play()
        {
            try
            {
                WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
                player.URL = sound;
                return;
            }
            catch
            {

            }
        }
    }
}
