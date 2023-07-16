using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationJsonSerializer
{
     internal class VideoYouTube
     {
        public string         Titre { get; set; }
        public int            Duree { get; set; }
        public YouTubeur      YouTubeur { get; set; }
        public List<string>?  Tags { get; set; }
    }
}
