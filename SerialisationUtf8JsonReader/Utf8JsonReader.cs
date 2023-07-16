using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SerialisationUtf8JsonReader
{
     internal class Utf8JsonReader
     {
          // Fields ---------------------------------------------------------------------------------------------------------------------------------
          string jsonData = """
               {
                    "nom"     : "POGAM",
                    "prenom"  : "Jean-Charles",
                    "age"     : 33
               }
               """;
          Utf8JsonReader i_redear = new Utf8JsonReader(Encoding.UTF8.GetBytes(jsonData));


          // Properties -----------------------------------------------------------------------------------------------------------------------------



          // Constructors ---------------------------------------------------------------------------------------------------------------------------



          // Methods --------------------------------------------------------------------------------------------------------------------------------
          public void m_Utf8JsonReader()
          {
               // Locals ----------------------------------------------------------------------------------------------------------------------------





               // Treatment -------------------------------------------------------------------------------------------------------------------------
               // Parcours du fichier XML
          }
     }
}
