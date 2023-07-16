using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SerialisationUtf8Json
{
     internal class SerialisationUtf8JsonReader
     {
          // Fields ---------------------------------------------------------------------------------------------------------------------------------




          // Properties -----------------------------------------------------------------------------------------------------------------------------




          // Constructors ---------------------------------------------------------------------------------------------------------------------------



          // Methods --------------------------------------------------------------------------------------------------------------------------------
          internal void m_Utf8JsonReader()
          {
               // Locals ----------------------------------------------------------------------------------------------------------------------------
               Utf8JsonReader reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(Program.jsonData),
                    new JsonReaderOptions
                    {
                         AllowTrailingCommas = true,
                         MaxDepth            = 12,
                         CommentHandling     = JsonCommentHandling.Skip
                    }
               );




               // Treatment -------------------------------------------------------------------------------------------------------------------------
               // Parcours du fichier XML
               while (reader.Read())
               {
                    if(reader.TokenType == JsonTokenType.PropertyName)
                    {
                         Console.WriteLine($"Je lis le nom d'une propriété : {reader.GetString()}");
                    }
                    else if (reader.TokenType == JsonTokenType.String)
                    {
                         Console.WriteLine($"Je lis du contenu (chaîne) : {reader.GetString()}");
                    }
                    else if (reader.TokenType == JsonTokenType.Number)
                    {
                         Console.WriteLine($"Je lis du contenu (nombre) : {reader.GetInt32()}");
                    }
               }
          }
     }
}
