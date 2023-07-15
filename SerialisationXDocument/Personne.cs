using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationXDocument
{
     internal class Personne
     {
          public string Nom { get; set; } = "";
          public string Prenom { get; set; } = "";
          public DateTime? DateDeNaissance { get; set; }
          public int Taille { get; set; }
     }
}
