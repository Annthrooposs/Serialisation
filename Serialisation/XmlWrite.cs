
using System.Xml;

namespace Serialisation
{
     internal class XmlWrite
     {

          // Fields --------------------------------------------------------------------------------------------------------------------------------- 
          //Personne personne = new Personne();
          XmlRead i_XmlRead = new XmlRead();


          // Properties -----------------------------------------------------------------------------------------------------------------------------



          // Constructors ---------------------------------------------------------------------------------------------------------------------------



          // Methods --------------------------------------------------------------------------------------------------------------------------------
          public void m_XmlWrite(string p_file)
          {
               // Locals ----------------------------------------------------------------------------------------------------------------------------
               XmlWriterSettings settings = new XmlWriterSettings
               {
                    Indent = true,
               };

               XmlWriter writer = XmlWriter.Create(@p_file, settings);



               // Treatment -------------------------------------------------------------------------------------------------------------------------
               // Ecriture dans le fichier 1er exemple
               //writer.WriteStartElement("Client");

               //writer.WriteElementString("Identité", "Jean-Charles POGAM");
               //// ou
               //writer.WriteStartElement("Identité");
               //writer.WriteValue("Pascale POGAM");
               //writer.WriteEndElement();

               //writer.WriteEndElement();
               //writer.Flush();





               //Ecriture dans le fichier 2ème exemple
               writer.WriteStartElement("Personne");

               writer.WriteStartElement("Nom");
               writer.WriteValue("DUPOND");
               writer.WriteEndElement();

               writer.WriteElementString("Prenom", "Victor");
               writer.WriteElementString("DateDeNaissance", "1988-12-18T00:00:00");

               writer.WriteStartElement("Taille");
               writer.WriteValue(181);
               writer.WriteEndElement();

               writer.WriteEndElement();
               writer.Flush();
          }
     }
}
