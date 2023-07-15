using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SerialisationXDocument
{
     internal class XmlXDocument
     {

          // Fields ---------------------------------------------------------------------------------------------------------------------------------
          //XDocument doc = XDocument.Load("TP_01.xml");

          Personne personne = new Personne();



          // Properties -----------------------------------------------------------------------------------------------------------------------------



          // Constructors ---------------------------------------------------------------------------------------------------------------------------



          // Methods --------------------------------------------------------------------------------------------------------------------------------
          public void m_XmlDocument(string p_file)
          {
               // Locals ----------------------------------------------------------------------------------------------------------------------------
               XDocument doc = XDocument.Load(p_file);



               // Treatment -------------------------------------------------------------------------------------------------------------------------
               // Parcours du fichier XML
               if (doc.Root is not null )
               {
                    foreach (var item in doc.Root.Elements())
                    {
                         if(item.Name == "Nom")
                         {
                              personne.Nom = item.Value;
                         }
                         else if (item.Name == "Prenom")
                         {
                              personne.Prenom = item.Value;
                         }
                         else if (item.Name == "DateDeNaissance")
                         {
                              personne.DateDeNaissance = DateTime.Parse(item.Value);
                         }
                         else if (item.Name == "Taille")
                         {
                              personne.Taille = byte.Parse(item.Value);
                         }
                    }
               }



               // Affichage à l'écran
               Console.WriteLine($"m_XmlDocument : {personne.Prenom} {personne.Nom} est né(e) le {personne.DateDeNaissance:dd/MM/yyyy} et mesure {personne.Taille} cm");
          }
     }
}
