
using Serialisation;
using System.Xml;

namespace Serialisation;

internal class Program
{
     private static void Main(string[] args)
     {
          // Fields ---------------------------------------------------------------------------------------------------------------------------------
          XmlRead  i_XmlRead   = new XmlRead();
          XmlWrite i_XmlWrite  = new XmlWrite();

          Personne personne = new Personne();



          // Properties -----------------------------------------------------------------------------------------------------------------------------




          // Methods --------------------------------------------------------------------------------------------------------------------------------



          // Routing --------------------------------------------------------------------------------------------------------------------------------
          i_XmlRead.m_XmlRead("TP_01.xml");
          i_XmlWrite.m_XmlWrite("TP_01_WrittenByJCP.xml");

     }
}