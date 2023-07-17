using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerialisationJsonSerializer
{
     internal class Livre
     {
          // Fields ---------------------------------------------------------------------------------------------------------------------------------



          // Properties -----------------------------------------------------------------------------------------------------------------------------
          public string  Titre     { get; set; } = "";
          public string  Auteur    { get; set; } = "";
          public int     NbPages   { get; set; }
          public string  ISBN      { get; set; } = "";



          // Constructors ---------------------------------------------------------------------------------------------------------------------------



          // Methods --------------------------------------------------------------------------------------------------------------------------------
     }
}
