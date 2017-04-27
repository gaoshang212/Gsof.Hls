using System;

namespace Gsof.Hls.M3u8
{
    public class Segment
    {
        public int Index { get; set; }

        public Uri Uri { get; set; }

        public double Duration { get; set; }

        public Key Key { get; set; }
    }
}