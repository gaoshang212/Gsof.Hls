using System;
using System.Collections.Generic;
using System.Linq;

namespace Gsof.Hls.M3u8
{
    public class M3U8
    {
        public List<Segment> Segments { get; set; }

        public static M3U8 Parser(Uri p_baseUri, IEnumerable<string> p_lines)
        {
            var baseUri = p_baseUri;

            if (p_lines == null)
            {
                throw new ArgumentNullException(nameof(p_lines));
            }

            var lines = p_lines.ToList();

            var first = lines.FirstOrDefault();

            if (first != "#EXTM3U")
            {
                throw new Exception("The lines is not m3u8 list.");
            }

            lines.RemoveAt(0);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                if (line.StartsWith("#EXT"))
                {
                    //HandleExt(line);
                }
                else if (!line.StartsWith("#"))
                {
                    //var uri = new M3U8Uri
                    //{
                    //    Uri = line
                    //};

                    //if (_tags.Count > 0 || _sharedTags.Count > 0)
                    //{
                    //    uri.Tags = _tags.Union(_sharedTags).ToArray();

                    //    _tags.Clear();
                    //}

                    //_playlist.Add(uri);
                }
            }
        }
    }
}