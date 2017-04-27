using System;

namespace Gsof.Hls.M3u8
{
    public class Key
    {
        public string Method { get; set; }

        public Uri Uri { get; set; }

        public byte[] Data { get; set; }

        public byte[] Iv { get; set; }
    }
}