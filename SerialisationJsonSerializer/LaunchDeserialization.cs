using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerialisationJsonSerializer
{
     internal static class LaunchDeserialization
     {
          // Fields ---------------------------------------------------------------------------------------------------------------------------------



          // Properties -----------------------------------------------------------------------------------------------------------------------------



          // Constructors ---------------------------------------------------------------------------------------------------------------------------



          // Methods --------------------------------------------------------------------------------------------------------------------------------
          internal static void m_DeSerialisation(string p_file)
          {

               // Locals ----------------------------------------------------------------------------------------------------------------------------
               string json = """
               [
                   {
                       "titre": "Harry Potter, I : Harry Potter à l'école des sorciers",
                       "auteur": "J.K. Rowling",
                       "nbPages": 320,
                       "ISBN": "2070584623"
                   },
                   {
                       "titre": "Harry Potter, II : Harry Potter et la Chambre des Secrets",
                       "auteur": "J.K. Rowling",
                       "nbPages": 368,
                       "ISBN": "207058464X"
                   },
                   {
                       "titre": "Harry Potter, III : Harry Potter et le prisonnier d'Azkaban",
                       "auteur": "J.K. Rowling",
                       "nbPages": 448,
                       "ISBN": "2070584925"
                   }
               ]
               """;


               List<Livre>? ll = JsonSerializer.Deserialize<List<Livre>>(json, new JsonSerializerOptions
               {
                    PropertyNameCaseInsensitive = true
               });





               // Treatment -------------------------------------------------------------------------------------------------------------------------
               if (ll is not null)
               {
                    foreach (Livre item in ll)
                    {
                         // Affichage à l'écran
                         Console.WriteLine($"m_DeSerialisation : le livre \"{item.Titre}\", écrit par {item.Auteur} comporte {item.NbPages} pages et possède le numéro ISBN {item.ISBN}.");
                    }
               }
          }

     }
}
