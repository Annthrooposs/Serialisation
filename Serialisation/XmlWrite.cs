using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Serialisation
{
     internal class XmlWrite
     {

          // Fields ---------------------------------------------------------------------------------------------------------------------------------



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
               // Ecriture dans le fichier
               writer.WriteStartElement("Client");

               writer.WriteElementString("Identité", "Jean-Charles POGAM");
               // ou
               writer.WriteStartElement("Identité");
               writer.WriteValue("Pascale POGAM");
               writer.WriteEndElement();

               writer.WriteEndElement();


               writer.Flush();



               //// Affichage à l'écran
               //// Parcours du fichier XML venat d'être créé
               //XmlReader reader = XmlReader.Create(@p_file);
               //XmlRead i_XmlRead = new XmlRead();

               //reader.MoveToContent();

               //reader.ReadStartElement("Client");

               //reader.ReadStartElement("Identité");
               //var identité = reader.ReadContentAsString();
               //reader.ReadEndElement();

               //reader.ReadEndElement();



               //// Affichage à l'écran
               //Console.WriteLine($"{identité}");





               //reader.MoveToContent();


               //writer.WriteStartElement("Personne");

               //writer.WriteStartElement("Nom");
               //writer.WriteValue("DUPOND");
               //writer.WriteEndElement();

               //writer.WriteElementString("Prenom", Victor);

               //writer.WriteElementString("DateDeNaissance", Victor);

               //writer.WriteStartElement("Taille");
               //writer.WriteValue(181);
               //writer.WriteEndElement();

               //reader.WriteEndElement();
          }
     }
}
