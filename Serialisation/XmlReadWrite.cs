using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Serialisation
{
     internal class XmlReadWrite
     {
          // Fields ---------------------------------------------------------------------------------------------------------------------------------
          Personne personne = new Personne();


          // Properties -----------------------------------------------------------------------------------------------------------------------------



          // Constructors ---------------------------------------------------------------------------------------------------------------------------



          // Methods --------------------------------------------------------------------------------------------------------------------------------
          public void m_XmlReadWrite(string p_input, string p_output = null)
          {
               // Locals ----------------------------------------------------------------------------------------------------------------------------
               XmlReaderSettings settingsReader = new XmlReaderSettings
               {
                    IgnoreComments = true,
               };

               XmlReader reader = XmlReader.Create(@p_input, settingsReader);



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
               Console.WriteLine($"m_XmlReadWrite : {personne.Prenom} {personne.Nom} est né(e) le {personne.DateDeNaissance:dd/MM/yyyy} et mesure {personne.Taille} cm");



               if (p_output is not null)
               {
                    // Locals ----------------------------------------------------------------------------------------------------------------------------
                    XmlWriterSettings settingsWriter = new XmlWriterSettings
                    {
                         Indent = true,
                    };

                    XmlWriter writer = XmlWriter.Create(@p_output, settingsWriter);



                    // Treatment -------------------------------------------------------------------------------------------------------------------------
                    writer.WriteStartElement("Personne");

                    writer.WriteStartElement("Nom");
                    writer.WriteValue(personne.Nom);
                    writer.WriteEndElement();

                    writer.WriteElementString("Prenom", personne.Prenom);
                    writer.WriteElementString("DateDeNaissance", personne.DateDeNaissance.ToString());

                    writer.WriteStartElement("Taille");
                    writer.WriteValue(personne.Taille);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                    writer.Flush();
               }
          }
     }
}
