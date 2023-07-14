
using System.Xml;

namespace Serialisation
{
     public class XmlRead
     {

          // Fields ---------------------------------------------------------------------------------------------------------------------------------
          Personne personne = new Personne();


          // Properties -----------------------------------------------------------------------------------------------------------------------------



          // Constructors ---------------------------------------------------------------------------------------------------------------------------



          // Methods --------------------------------------------------------------------------------------------------------------------------------
          public void m_XmlRead(string p_file)
          {
               // Locals ----------------------------------------------------------------------------------------------------------------------------
               XmlReaderSettings settings = new XmlReaderSettings
               {
                    IgnoreComments = true,
               };

               XmlReader reader = XmlReader.Create(@p_file, settings);



               // Treatment -------------------------------------------------------------------------------------------------------------------------
               // Parcours du fichier XML
               reader.MoveToContent();


               reader.ReadStartElement("Personne");

                    reader.ReadStartElement("Nom");
                    personne.Nom = reader.ReadContentAsString();
                    reader.ReadEndElement();

                    reader.ReadStartElement("Prenom");
                    personne.Prenom = reader.ReadContentAsString();
                    reader.ReadEndElement();

                    reader.ReadStartElement("DateDeNaissance");
                    personne.DateDeNaissance = reader.ReadContentAsDateTime();
                    reader.ReadEndElement();

                    reader.ReadStartElement("Taille");
                    personne.Taille = reader.ReadContentAsInt();
                    reader.ReadEndElement();

               reader.ReadEndElement();



               // Affichage à l'écran
               Console.WriteLine($"{ personne.Prenom} {personne.Nom} est né(e) le {personne.DateDeNaissance:dd/MM/yyyy} et mesure {personne.Taille} cm");
          }
     }
}
