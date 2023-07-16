using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;        // ReferenceHandler
using System.Threading.Tasks;

namespace SerialisationJsonSerializer
{
     internal class LaunchSerialisation
     {
          // Fields ---------------------------------------------------------------------------------------------------------------------------------




          // Properties -----------------------------------------------------------------------------------------------------------------------------




          // Constructors ---------------------------------------------------------------------------------------------------------------------------



          // Methods --------------------------------------------------------------------------------------------------------------------------------
          internal void m_Serialisation()
          {

               // Locals ----------------------------------------------------------------------------------------------------------------------------
               YouTubeur youtuber = new YouTubeur()
               {
                    Nom = "VloggerDeFrance",
                    Prenom = "Charles",
                    TitreChaine = "Ma chaîne de Vlogs"
               };

               List<VideoYouTube> videos = new List<VideoYouTube>
               {
               new VideoYouTube {Titre = "Voyage à Rome",                       Duree = 467,   Tags = new List<string>() {"Voyage", "Italie"},   YouTubeur = youtuber},
               new VideoYouTube {Titre = "Ma nouvelle voiture !!!",             Duree = 235,   Tags = new List<string>() {"Voiture"},            YouTubeur = youtuber},
               new VideoYouTube {Titre = "Ma recette de ka crème au chocolat",  Duree = 665,   Tags = new List<string>() {"Voyage", "Italie"},   YouTubeur = youtuber}
               };

               youtuber.Videos = videos;



               // Treatment -------------------------------------------------------------------------------------------------------------------------
               string json = JsonSerializer.Serialize(youtuber, new JsonSerializerOptions
               {
                    ReferenceHandler    = ReferenceHandler.Preserve,
                    WriteIndented       = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
               });

               Console.WriteLine(json);
          }
     }
}
