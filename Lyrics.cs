using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Globalization;
using System.Windows;

namespace music
{
    public class Lyrics
    {
        public string completeLyrics;
        public Dictionary<String , String> lyrics;

        public Lyrics(String l)
        {
            completeLyrics = l;
        }

        public String getTime(int n)
        {
            return null;
        }

        public int getLine(TimeSpan t)
        {
            return 0;
        }
    }
}
