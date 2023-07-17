using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerialisationUtf8Json
{
     internal class SerialisationUtf8JsonWriter
     {
          // Fields ---------------------------------------------------------------------------------------------------------------------------------





          // Properties -----------------------------------------------------------------------------------------------------------------------------




          // Constructors ---------------------------------------------------------------------------------------------------------------------------



          // Methods --------------------------------------------------------------------------------------------------------------------------------
          internal void m_Utf8JsonWritter()
          {
               // Locals ----------------------------------------------------------------------------------------------------------------------------
               using MemoryStream menStream = new MemoryStream();

               using Utf8JsonWriter writer = new Utf8JsonWriter(menStream,
                    new JsonWriterOptions
                    {
                         Indented = true
                    }); ;




               // Treatment -------------------------------------------------------------------------------------------------------------------------
               // Ecriture
               writer.WriteStartObject();

               writer.WritePropertyName("Nom");
               writer.WriteStringValue("LOHEAC");

               writer.WritePropertyName("PRENOM");
               writer.WriteStringValue("Younick");

               writer.WritePropertyName("Age");
               writer.WriteNumberValue(33);

               writer.WriteEndObject();

               writer.Flush();
               menStream.Position = 0;
               Console.WriteLine(Encoding.UTF8.GetString(menStream.ToArray()));
          }
}
}
