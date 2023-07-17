using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationJsonSerializer
{
     internal class YouTubeur
     {
          // Fields ---------------------------------------------------------------------------------------------------------------------------------




          // Properties -----------------------------------------------------------------------------------------------------------------------------
          public string                 Nom { get; set; } = "";
          public string                 Prenom { get; set; } = "";
          public string                 TitreChaine { get; set; } = "";
          public List<VideoYouTube>?    Videos { get; set; }



        // Constructors ---------------------------------------------------------------------------------------------------------------------------



        // Methods --------------------------------------------------------------------------------------------------------------------------------
    }
}
