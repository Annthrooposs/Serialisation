using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation
{
    class Program.Methods.Shared
    {
          public Personne LecturePersonne(string p_file)
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
		}
    }
}
