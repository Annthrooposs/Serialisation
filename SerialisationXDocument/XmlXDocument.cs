
using System.Xml.Linq;

namespace SerialisationXDocument
{
     internal class XmlXDocument
     {

          // ========================================================================================================================================
          //                                                                                                                                        !
          //                                                             Fields                                                                     !
          //                                                                                                                                        !
          // ========================================================================================================================================
          Personne personne = new Personne();



          XElement adresse1 = new XElement("Adresse", "1, Rue Crémieux - 30000 - Nîmes");
          XElement adresse2 = new XElement("Adresse", "1, Place de la comédie - 34000 - Montpellier");





          // ========================================================================================================================================
          //                                                                                                                                        !
          //                                                            Properties                                                                  !
          //                                                                                                                                        !
          // ========================================================================================================================================





          // ========================================================================================================================================
          //                                                                                                                                        !
          //                                                           Constructors                                                                 !
          //                                                                                                                                        !
          // ========================================================================================================================================





          // ========================================================================================================================================
          //                                                                                                                                        !
          //                                           Method - Ajout d'un noeud dans le fichier XML                                                !
          //                                                                                                                                        !
          // ========================================================================================================================================
          public void m_XmlDocumentRead(string p_file)
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
                              //doc.Root.AddAfterSelf(adresse1);
                         }
                    }
               }



               // Affichage à l'écran
               Console.WriteLine($"m_XmlDocument : {personne.Prenom} {personne.Nom} est né(e) le {personne.DateDeNaissance:dd/MM/yyyy} et mesure {personne.Taille} cm");
          }





          // ========================================================================================================================================
          //                                                                                                                                        !
          //                                            Method - Ajout d'un noeud dans le fichier XML                                               !
          //                                                                                                                                        !
          // ========================================================================================================================================
          public void m_XmlDocumentAdd(string p_file)
          {
               // Locals ----------------------------------------------------------------------------------------------------------------------------
               XDocument doc = XDocument.Load(p_file);



               // Treatment -------------------------------------------------------------------------------------------------------------------------
               // Parcours du fichier XML
               if (doc.Root is not null)
               {
                    XElement? elementTaille = doc.Root.Element("Taille");

                    if (elementTaille is not null )
                    {
                         elementTaille.AddAfterSelf(adresse2);
                    }
               }



               // Affichage à l'écran
               Console.WriteLine($"m_XmlDocumentAdd : {doc.ToString()}");
          }
     }
}
